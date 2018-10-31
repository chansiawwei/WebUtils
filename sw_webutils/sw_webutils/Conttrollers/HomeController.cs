using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sw_webutils.Models;


namespace sw_webutils.Conttrollers
{
  
   

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Weather()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Weather(WeatherData weatherData)
        {
            //return View();
            //return Content("Hello " +  weatherData.City);

          if (ModelState.IsValid)
         {
                
            string City = weatherData.City;
            City = City.Replace(' ', '-');
            Weather weather = new Weather();
            weather.City = City;
         // weather.ParseData();
            WeatherData data = weather.GetWebData();
              // data.Text = weatherData.Text;
                return View("Weather", data);
         }

          return View(weatherData);
        }

        [HttpGet]
        public IActionResult Country()
        {
            return View();
        }


      
        [HttpPost]
        public IActionResult Country(CountryData countryData)
        {
            //When input country is empty
            if (ModelState.IsValid) { 
            //return Content("Hello " + countryData.CountryName);
            Country country = new Country();
            country.Nation = countryData.CountryName;
            //country.ParseData();
            CountryData data = country.GetWebData();
                data.CountryName = countryData.CountryName;
            return View("Country", data);
            }
           
            return View(countryData);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }


    }
}