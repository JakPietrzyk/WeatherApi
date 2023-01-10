using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    internal class ApiController
    {
        static public async Task<Root> GetData(string url)
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromMinutes(1);
                HttpResponseMessage responseMessage = client.GetAsync(url).Result;
                if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseString = await responseMessage.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<Root>(responseString);
                    return responseObject;
                }
                return new Root();
            }
        }
    }
}
