using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;


namespace sw_webutils.Models
{
    public class Weather : MakeWebRequest, IWebData<WeatherData>
    {
                private WeatherData _weatherData;

    public Weather()
    {
        _weatherData = new WeatherData();
    }

      public string City { get; set; }
        
        private string url = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22{0}%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";


    public WeatherData GetWebData()
    {
            ParseData();
        return _weatherData;
    }

    public override void ParseData()
    {
        string cityUrl = string.Format(url,City);
        string json = GetJsonString(cityUrl);

           
                JObject jsonObj = JObject.Parse(json);
            int? count = (int)jsonObj["query"]["count"];
            if (count != 0) {
                _weatherData.City = (string)jsonObj["query"]["results"]["channel"]["location"]["city"];
                _weatherData.Text = (string)jsonObj["query"]["results"]["channel"]["item"]["condition"]["text"];
                _weatherData.Huminity = (string)jsonObj["query"]["results"]["channel"]["atmosphere"]["humidity"];
                _weatherData.SunRise = (string)jsonObj["query"]["results"]["channel"]["astronomy"]["sunrise"];
                _weatherData.SunSet = (string)jsonObj["query"]["results"]["channel"]["astronomy"]["sunset"];
                _weatherData.Count= (int)jsonObj["query"]["count"];





                Console.WriteLine("Huminity:{0} SunRise:{1} SunSet:{2} Weather:{3} ",

                    _weatherData.Huminity,
                    _weatherData.SunRise,
                    _weatherData.SunSet,
                    _weatherData.Text
                         );

                string forecastString = (string)jsonObj["query"]["results"]["channel"]["item"]["forecast"].ToString();
                //WeatherData[] forecasts =jsonObj["query"]["results"]["channel"]["item"]["forecast"].ToArray<WeatherData>();

                var forecasts = JsonConvert.DeserializeObject<List<WeatherForecastData>>(forecastString);
            
            foreach (var f in forecasts)
                {
                
                    Console.WriteLine(f.Date);
                    Console.WriteLine(f.Day);
                    Console.WriteLine(f.High);
                    Console.WriteLine(f.Low);
                    Console.WriteLine(f.Text);
                    Console.WriteLine();
                    _weatherData.WeatherForecastDatas.Add(f);

    
                }
            }

        }
        }

}

