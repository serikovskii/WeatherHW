﻿using Newtonsoft.Json;

namespace WheatherHW.Models
{
    public class Request
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }
}