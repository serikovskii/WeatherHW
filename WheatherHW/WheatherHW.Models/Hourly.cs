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

        [JsonProperty("tempF")]
        public string TempF { get; set; }

        [JsonProperty("windspeedMiles")]
        public string WindspeedMiles { get; set; }

        [JsonProperty("windspeedKmph")]
        public string WindspeedKmph { get; set; }

        [JsonProperty("winddirDegree")]
        public string WinddirDegree { get; set; }

        [JsonProperty("winddir16Point")]
        public string Winddir16Point { get; set; }

        [JsonProperty("weatherCode")]
        public string WeatherCode { get; set; }

        [JsonProperty("weatherIconUrl")]
        public IList<WeatherIconUrl> WeatherIconUrl { get; set; }

        [JsonProperty("weatherDesc")]
        public IList<WeatherDesc> WeatherDesc { get; set; }

        [JsonProperty("precipMM")]
        public string PrecipMM { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("cloudcover")]
        public string Cloudcover { get; set; }

        [JsonProperty("HeatIndexC")]
        public string HeatIndexC { get; set; }

        [JsonProperty("HeatIndexF")]
        public string HeatIndexF { get; set; }

        [JsonProperty("DewPointC")]
        public string DewPointC { get; set; }

        [JsonProperty("DewPointF")]
        public string DewPointF { get; set; }

        [JsonProperty("WindChillC")]
        public string WindChillC { get; set; }

        [JsonProperty("WindChillF")]
        public string WindChillF { get; set; }

        [JsonProperty("WindGustMiles")]
        public string WindGustMiles { get; set; }

        [JsonProperty("WindGustKmph")]
        public string WindGustKmph { get; set; }

        [JsonProperty("FeelsLikeC")]
        public string FeelsLikeC { get; set; }

        [JsonProperty("FeelsLikeF")]
        public string FeelsLikeF { get; set; }

        [JsonProperty("chanceofrain")]
        public string Chanceofrain { get; set; }

        [JsonProperty("chanceofremdry")]
        public string Chanceofremdry { get; set; }

        [JsonProperty("chanceofwindy")]
        public string Chanceofwindy { get; set; }

        [JsonProperty("chanceofovercast")]
        public string Chanceofovercast { get; set; }

        [JsonProperty("chanceofsunshine")]
        public string Chanceofsunshine { get; set; }

        [JsonProperty("chanceoffrost")]
        public string Chanceoffrost { get; set; }

        [JsonProperty("chanceofhightemp")]
        public string Chanceofhightemp { get; set; }

        [JsonProperty("chanceoffog")]
        public string Chanceoffog { get; set; }

        [JsonProperty("chanceofsnow")]
        public string Chanceofsnow { get; set; }

        [JsonProperty("chanceofthunder")]
        public string Chanceofthunder { get; set; }

        [JsonProperty("uvIndex")]
        public string UvIndex { get; set; }
    }
}