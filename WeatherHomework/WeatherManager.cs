using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHomework
{
    internal class WeatherManager
    {
        public double getWeather(string city, string unit)
        {

            WebClient myWebClient = new WebClient();


            string weatherURL = $"https://www.google.com/search?q=weather+{city}";
            string data = myWebClient.DownloadString(weatherURL);

            try
            {
                int indexOfDegree = data.IndexOf("°");
                int startIndex = data.LastIndexOf('>', indexOfDegree) + 1;
                string temperatureValue = data.Substring(startIndex, indexOfDegree - startIndex);

                return getUnitTemperature(Convert.ToDouble(temperatureValue), unit);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public double getUnitTemperature(double temperature, string unit)
        {

            if (unit == "C")
                return temperature;
            if (unit == "F")
                return (temperature*1.8)+32;
            if (unit == "K")
                return temperature+273.15;

            throw new Exception("Unknown unit");

        }

    }
}
