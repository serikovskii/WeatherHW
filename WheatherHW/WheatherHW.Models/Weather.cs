using Newtonsoft.Json;
using System.Collections.Generic;

namespace WheatherHW.Models
{
    public class Weather
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        
        [JsonProperty("hourly")]
        public List<Hourly> Hourly { get; set; }
    }
}