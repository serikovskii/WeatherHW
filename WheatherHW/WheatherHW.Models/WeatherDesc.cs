using Newtonsoft.Json;

namespace WheatherHW.Models
{
    public class WeatherDesc
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}