using UnityEngine;
using Newtonsoft.Json;
using Assets.Script.Model;
using System;
using System.Threading.Tasks;

public class Application : MonoBehaviour
{
    public VitalSignsMonitorController VitalSignsMonitorController;
    //public QRCodeController QRCodeController;

    public void Start()
    {
        VitalSignsMonitorController.Init();
        // QRCodeController.Init((qrInfo) => QRCodeFound(qrInfo));

        _ = ParseQrCodeString("{\"deviceId\": \"PGNLNZ97M18G479M\"}");
    }

    private async void QRCodeFound(QRInfo qrInfo)
    {
        await this.ParseQrCodeString(qrInfo.Data);
    }

    private async Task ParseQrCodeString(string data)
    {
        try
        {
            var qrModel = JsonConvert.DeserializeObject<QrCodeInfoModel>(data);
            Debug.Log($"[QRCodeFoundCallback] {qrModel.DeviceId}");
            //this.QRCodeController.Close();

            await this.VitalSignsMonitorController.OnStartController(qrModel.DeviceId);
        }
        catch (Exception e)
        {
            Debug.LogError($"[QRCodeFoundCallback] Error: {e.Message}");
        }
    }

    public void Close()
    {
        UnityEngine.Application.Quit();
    }
}
