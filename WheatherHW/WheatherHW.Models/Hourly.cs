using Newtonsoft.Json;
using System.Collections.Generic;

namespace WheatherHW.Models
{
    public class Hourly
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("tempC")]
        public string TempC { get; set; }

        [JsonProperty("windspeedKmph")]
        public string WindspeedKmph { get; set; }

        [JsonProperty("weatherIconUrl")]
        public List<WeatherIconUrl> WeatherIconUrl { get; set; }

        [JsonProperty("weatherDesc")]
        public List<WeatherDesc> WeatherDesc { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("FeelsLikeC")]
        public string FeelsLikeC { get; set; }

    }
}