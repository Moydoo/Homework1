using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherManager manager = new WeatherManager();
            double temperature = manager.getWeather("Warsaw", "F");

            Console.WriteLine(temperature);

            Console.ReadKey();
        }
    }
}
