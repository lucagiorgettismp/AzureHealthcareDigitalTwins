using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace Assets.Script.Model
{
    public class QrCodeInfoModel
    {
        [Preserve]
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }
}
