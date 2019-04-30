using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WheatherHW.Models
{
    public class Data
    {
        [JsonProperty("request")]
        public IList<Request> Request { get; set; }

        [JsonProperty("current_condition")]
        public IList<CurrentCondition> CurrentCondition { get; set; }

        [JsonProperty("weather")]
        public IList<Weather> Weather { get; set; }

        [JsonProperty("ClimateAverages")]
        public IList<ClimateAverage> ClimateAverages { get; set; }
    }
}
