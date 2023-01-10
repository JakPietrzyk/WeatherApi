using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    internal class CurrentWeather
    {
        public string time { get; set; }
        public double temperature { get; set; }
        public double windspeed { get; set; }
    }
}
