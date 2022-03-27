using Newtonsoft.Json;

namespace Assets.Script.Model
{
    class QrCodeInfoModel
    {
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }
}
