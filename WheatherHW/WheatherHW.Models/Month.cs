using Newtonsoft.Json;

namespace WheatherHW.Models
{
    public class Month
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avgMinTemp")]
        public string AvgMinTemp { get; set; }

        [JsonProperty("avgMinTemp_F")]
        public string AvgMinTempF { get; set; }

        [JsonProperty("absMaxTemp")]
        public string AbsMaxTemp { get; set; }

        [JsonProperty("absMaxTemp_F")]
        public string AbsMaxTempF { get; set; }

        [JsonProperty("avgDailyRainfall")]
        public string AvgDailyRainfall { get; set; }
    }
}