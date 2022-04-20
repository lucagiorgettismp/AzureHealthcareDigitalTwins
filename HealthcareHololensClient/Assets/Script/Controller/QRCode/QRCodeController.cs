using System;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;

public class QRCodeController : MonoBehaviour
{
    [SerializeField]
    float QrObservationTimeOut = 3500;

    private IQRCodeTrackingService _qrCodeTrackingService;
    private QRInfo _lastSeenCode;
    private Action<QRInfo> _actionSuccess;

    private IQRCodeTrackingService QRCodeTrackingService
    {
        get
        {
            while (!MixedRealityToolkit.IsInitialized && Time.time < 5);
            return _qrCodeTrackingService ??= MixedRealityToolkit.Instance.GetService<IQRCodeTrackingService>();
        }
    }

    internal void StopController()
    {
        QRCodeTrackingService.Disable();
    }

    public void Init(Action<QRInfo> actionSuccess)
    {
        if (!QRCodeTrackingService.IsSupported)
        {
            throw new QRCodeTrackingServiceNotSupportedException("Not supported on Windows platform");
        }

        if (QRCodeTrackingService.IsInitialized)
        {
            StartTracking();
        }
        else
        {
            QRCodeTrackingService.Initialized += QRCodeTrackingService_Initialized;
        }

        this._actionSuccess = actionSuccess;
    }

    private void QRCodeTrackingService_Initialized(object sender, EventArgs e)
    {
        StartTracking();
    }

    private void StartTracking()
    {
        QRCodeTrackingService.QRCodeFound += QRCodeTrackingService_QRCodeFound;
        QRCodeTrackingService.Enable();
    }

    private void QRCodeTrackingService_QRCodeFound(object sender, QRInfo codeReceived)
    {
        Debug.Log($"[QRCodeDiplayController]  QR Code found: {codeReceived.Data}"); 
        _actionSuccess(codeReceived);
    }

    private void Update()
    {
        if (_lastSeenCode == null)
        {
            return;
        }
        if (Math.Abs(
            (_lastSeenCode.LastDetectedTime.UtcDateTime - DateTimeOffset.UtcNow).TotalMilliseconds) >
              QrObservationTimeOut)
        {
            _lastSeenCode = null;
        }
    }
}
