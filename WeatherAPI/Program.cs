using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WeatherAPI;

namespace Program
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://api.open-meteo.com/v1/forecast?latitude=50.06&longitude=19.94&hourly=temperature_2m&current_weather=true&timezone=Europe%2FBerlin&start_date=2023-01-10&end_date=2023-01-10";
            Root result = await ApiController.GetData(url);
            result.PrintCurrentWeather();
            result.PrintTemperatureWithDate();
            result.PrintOnlyToday();
        }
    }
}