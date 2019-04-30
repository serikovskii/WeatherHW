using Newtonsoft.Json;

namespace WheatherHW.Models
{
    public class WeatherIconUrl
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}