using System;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;

public class QRTrackerController : MonoBehaviour
{
    [SerializeField]
    public SpatialGraphCoordinateSystemSetter SpatialGraphCoordinateSystemSetter;

    [SerializeField]
    public string LocationQrValue = string.Empty;

    private Transform _markerHolder;
    private AudioSource _audioSource;
    private GameObject _markerDisplay;
    private QRInfo _lastMessage;

    public bool IsTrackingActive { get; private set; } = true;

    private IQRCodeTrackingService qrCodeTrackingService;

    private IQRCodeTrackingService QRCodeTrackingService
    {
        get
        {
            while (!MixedRealityToolkit.IsInitialized && Time.time < 5) { }
            return qrCodeTrackingService ??
                    (qrCodeTrackingService = MixedRealityToolkit.Instance.GetService<IQRCodeTrackingService>());
        }
    }

    private void Start()
    {
        if (!QRCodeTrackingService.IsSupported)
        {
            return;
        }

        _markerHolder = SpatialGraphCoordinateSystemSetter.gameObject.transform;
        _markerDisplay = _markerHolder.GetChild(0).gameObject;
        _markerDisplay.SetActive(false);

        _audioSource = _markerHolder.gameObject.GetComponent<AudioSource>();

        QRCodeTrackingService.QRCodeFound += ProcessTrackingFound;
        SpatialGraphCoordinateSystemSetter.PositionAcquired += SetPosition;
        SpatialGraphCoordinateSystemSetter.PositionAcquisitionFailed +=
            (s, e) => ResetTracking();

        if (QRCodeTrackingService.IsInitialized)
        {
            StartTracking();
        }
        else
        {
            QRCodeTrackingService.Initialized += QRCodeTrackingService_Initialized;
        }
    }

    private void QRCodeTrackingService_Initialized(object sender, EventArgs e)
    {
        StartTracking();
    }

    private void StartTracking()
    {
        QRCodeTrackingService.Enable();
    }

    public void ResetTracking()
    {
        if (QRCodeTrackingService.IsInitialized)
        {
            _markerDisplay.SetActive(false);
            IsTrackingActive = true;
        }
    }

    private void ProcessTrackingFound(object sender, QRInfo msg)
    {
        if (msg == null || !IsTrackingActive)
        {
            return;
        }

        _lastMessage = msg;

        if (msg.Data == LocationQrValue && Math.Abs((DateTimeOffset.UtcNow - msg.LastDetectedTime.UtcDateTime).TotalMilliseconds) < 200)
        {
            SpatialGraphCoordinateSystemSetter.SetLocationIdSize(msg.SpatialGraphNodeId,
                msg.PhysicalSideLength);
        }
    }

    private void SetPosition(object sender, Pose pose)
    {
        IsTrackingActive = false;
        _markerHolder.localScale = Vector3.one * _lastMessage.PhysicalSideLength;
        _markerDisplay.SetActive(true);
        PositionSet?.Invoke(this, pose);
        _audioSource.Play();
    }

    public EventHandler<Pose> PositionSet;
}
