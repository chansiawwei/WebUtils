using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sw_webutils.Models
{
    public class WeatherData
    {
        private string _huminity;
        private string _sunrise;
        private string _sunset;
        private string _text;


        [Required(ErrorMessage = "Please enter a city.")]
        public string City { get; set; }

      
        public string Huminity { get { return _huminity; } set { _huminity = value; } }
        public string SunRise { get { return _sunrise; } set { _sunrise = value; } }
        public string SunSet { get { return _sunset; } set { _sunset = value; } }
        public string Text { get { return _text; } set { _text = value; } }
        public int Count { get; set; }

        private List<WeatherForecastData> _weatherForecastDatas;

        public WeatherData()
        {
            _weatherForecastDatas = new List<WeatherForecastData>();
        }

        public List<WeatherForecastData> WeatherForecastDatas
        {
            get
            {
                return _weatherForecastDatas;

            }
        }

        public void AddWeatherForecastData(WeatherForecastData data)
        {
            _weatherForecastDatas.Add(data);
        }
    }
}
