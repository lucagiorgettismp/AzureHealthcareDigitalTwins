using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.MixedReality.QR;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;

[MixedRealityExtensionService(SupportedPlatforms.WindowsUniversal)]
public class QRCodeTrackingService : BaseExtensionService, IQRCodeTrackingService
{
    private readonly QRCodeTrackingServiceProfile _profile;
    public QRCodeTrackingService(string name, uint priority, BaseMixedRealityProfile profile) : base(name, priority, profile)
    {
        this._profile = (QRCodeTrackingServiceProfile)profile;
    }

    public event EventHandler Initialized;
    public event EventHandler<QRInfo> QRCodeFound;

    public bool InitializationFailed { get; private set; }
    public string ErrorMessage { get; private set; }
    public bool IsSupported { get; private set; }
    public bool IsTracking { get; private set; }
    public bool IsInitialized { get; private set; }
    public string ProgressMessages { get; private set; }

    private QRCodeWatcher _qrTracker;
    private QRCodeWatcherAccessStatus _accessStatus;

    private int _initializationAttempt = 0;

    private readonly List<string> _messageList = new List<string>();

    public override void Initialize()
    {
        _ = InitializeTracker();
    }

    private async Task InitializeTracker()
    {
        try
        {
            IsSupported = QRCodeWatcher.IsSupported();
            if (IsSupported)
            {
                SendProgressMessage($"Initializing QR tracker attempt {++_initializationAttempt}");

                var capabilityTask = QRCodeWatcher.RequestAccessAsync();
                await capabilityTask.AwaitWithTimeout(_profile.AccessRetryTime,
                    ProcessTrackerCapabilityReturned,
                    () => _ = InitializeTracker());
            }
            else
            {
                InitializationFail("QR tracking not supported");
            }
        }
        catch (Exception ex)
        {
            InitializationFail($"QRCodeTrackingService initialization failed: {ex}");
        }
    }

    private void ProcessTrackerCapabilityReturned(QRCodeWatcherAccessStatus ast)
    {
        if (ast != QRCodeWatcherAccessStatus.Allowed)
        {
            InitializationFail($"QR tracker could not be initialized: {ast}");
        }
        _accessStatus = ast;
    }

    public override void Update()
    {
        if (_qrTracker == null && _accessStatus == QRCodeWatcherAccessStatus.Allowed)
        {
            SetupTracking();
        }
    }

    private void SetupTracking()
    {
        _qrTracker = new QRCodeWatcher();
        _qrTracker.Updated += QRCodeWatcher_Updated;
        IsInitialized = true;
        Initialized?.Invoke(this, new EventArgs());
        SendProgressMessage("QR tracker initialized");
    }

    private void QRCodeWatcher_Updated(object sender, QRCodeUpdatedEventArgs e)
    {
        SendProgressMessage($"Found QR code {e.Code.Data}");
        QRCodeFound?.Invoke(this, new QRInfo(e.Code));
    }

    public override void Enable()
    {
        base.Enable();
        if (!IsInitialized)
        {
            return;
        }

        try
        {
            _qrTracker.Start();
            IsTracking = true;
            SendProgressMessage("Enabled tracking");
        }
        catch (Exception ex)
        {
            InitializationFail($"QRCodeTrackingService starting QRCodeWatcher Exception: {ex}");
        }
    }

    public override void Disable()
    {
        base.Disable();
        if (IsTracking)
        {
            IsTracking = false;
            _qrTracker?.Stop();
            SendProgressMessage("Disabled tracking");
        }
    }

    private void InitializationFail(string message)
    {
        SendProgressMessage(message);
        ErrorMessage = message;
        InitializationFailed = true;
    }

    private void SendProgressMessage(string msg)
    {
        if (!_profile.ExposedProgressMessages)
        {
            return;
        }

        Debug.Log(msg);
        _messageList.Add(msg);
    }
}