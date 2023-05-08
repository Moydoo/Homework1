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
            Console.WriteLine("Insert the city you want to check the temperature: ");
            string city = Console.ReadLine();
            Console.WriteLine("Insert unit of the temperature (C, F, K): ");
            string unit = Console.ReadLine();
            double temperature = manager.getWeather(city, unit);

            Console.WriteLine($"The temperature for the {city} is {temperature}{unit}");

            Console.ReadKey();
        }
    }
}
