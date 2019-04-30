using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WheatherHW.Models;


namespace WheatherHW.Serialize
{
    public class DeserializeJson
    {
        public Data Start()
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("http://api.worldweatheronline.com/premium/v1/weather.ashx?key=9b39d1d764e449cf89c45448193004&q=Astana&num_of_days=7&format=json");
            var result = JsonConvert.DeserializeObject<Data>(json);

            return result;
        }
    }
}
