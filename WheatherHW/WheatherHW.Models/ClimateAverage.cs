using Newtonsoft.Json;
using System.Collections.Generic;

namespace WheatherHW.Models
{
    public class ClimateAverage
    {
        [JsonProperty("month")]
        public IList<Month> Month { get; set; }
    }
}