using System;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;

public class QRCodeController : MonoBehaviour
{
    [SerializeField]
    private float qrObservationTimeOut = 3500;

    private IQRCodeTrackingService qrCodeTrackingService;

    private QRInfo lastSeenCode;
    private Action<QRInfo> actionSuccess;

    private IQRCodeTrackingService QRCodeTrackingService
    {
        get
        {
            while (!MixedRealityToolkit.IsInitialized && Time.time < 5) ;
            return qrCodeTrackingService ??= MixedRealityToolkit.Instance.GetService<IQRCodeTrackingService>();
        }
    }

    internal void Close()
    {
        this.gameObject.SetActive(false);
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

        this.actionSuccess = actionSuccess;
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
        this.gameObject.SetActive(false);
        actionSuccess(codeReceived);
    }

    private void Update()
    {
        if (lastSeenCode == null)
        {
            return;
        }
        if (Math.Abs(
            (lastSeenCode.LastDetectedTime.UtcDateTime - DateTimeOffset.UtcNow).TotalMilliseconds) >
              qrObservationTimeOut)
        {
            lastSeenCode = null;
        }
    }
}
