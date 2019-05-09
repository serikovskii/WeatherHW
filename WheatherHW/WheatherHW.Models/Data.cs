using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WheatherHW.Models
{
    public class Data
    {
        [JsonProperty("request")]
        public List<Request> Request { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
    }
}
