using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    internal class Root
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
        public Hourly hourly { get; set; }
        public CurrentWeather current_weather { get; set; }  

        public void PrintCurrentWeather()
        {
            Console.WriteLine("Current Weather is:");
            Console.WriteLine(current_weather.temperature + " °C and wind speed is " + current_weather.windspeed + " km/h" );
        }
        public void PrintTemperatureWithDate()
        {
            double max = hourly.temperature_2m.Max();
            double average = hourly.temperature_2m.Average();
            double last = hourly.temperature_2m[0];
            Console.WriteLine("Last known weather is:");
            for (int i = 0; i < hourly.temperature_2m.Count(); i++)
            {
                Console.Write(hourly.temperature_2m[i] +"\t|  "+ hourly.time[i]);
                if (hourly.temperature_2m[i]>last)
                {
                    Console.WriteLine("     ^");
                }
                else if (hourly.temperature_2m[i] < last)
                {
                    Console.WriteLine("     v");
                }
                else
                {
                    Console.WriteLine("     =");
                }

            }
            Console.WriteLine($"Average: {average}, Max: {max}");
        }
        public void PrintOnlyToday()
        {
            string str = current_weather.time;
            str = str.Substring(0,str.Length-5);
            Console.WriteLine(str);

            double last = hourly.temperature_2m[0];
            for (int i = 0; i < hourly.temperature_2m.Count(); i++)
            {
                if (hourly.time[i].Contains(str))
                {
                    Console.Write(hourly.temperature_2m[i] + "\t|  " + hourly.time[i]);
                    if (hourly.temperature_2m[i] > last)
                    {
                        Console.WriteLine("     ^");
                    }
                    else if (hourly.temperature_2m[i] < last)
                    {
                        Console.WriteLine("     v");
                    }
                    else
                    {
                        Console.WriteLine("     =");
                    }
                }
                

            }

        }
    }
}
