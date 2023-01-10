using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    internal class Hourly
    {
        public List<string> time { get; set; }
        public List<double> temperature_2m { get; set; }
    }
}
