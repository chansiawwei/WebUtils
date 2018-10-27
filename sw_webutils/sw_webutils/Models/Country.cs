using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace sw_webutils.Models
{
    public class Country : MakeWebRequest, IWebData<CountryData>
    {
        private CountryData _countryData;

        public string Nation { get; set; }

        private string url = "https://restcountries.eu/rest/v2/name/{0}";

        public Country()
        {
            _countryData = new CountryData();
        }

        public CountryData GetWebData()
        {
            ParseData();
            return _countryData;
        }

        public override void ParseData()
        {
            string countryUrl = string.Format(url, Nation);
            string json = GetJsonString(countryUrl);
            //JObject jsonObj = JObject.Parse(json);

            if (json != "")
            {

                JArray jsonAry = JArray.Parse(json);

                string str = jsonAry.First.ToString();
                JObject jsonObj = JObject.Parse(str);

                _countryData.CountryName = (string)jsonObj["name"];
                _countryData.Capital = (string)jsonObj["capital"];
                _countryData.Area = (string)jsonObj["area"];
                _countryData.Population = (string)jsonObj["population"];
                _countryData.FalgUrl = (string)jsonObj["flag"];

                JObject jobj = JObject.Parse(((string)jsonObj["currencies"].First.ToString()));
                _countryData.CurrencyCode = (string)jobj["code"];
                
                Console.WriteLine("Name:{0} Capital:{1} CurrencyCode:{2} Area:{3} Population:{4} Flag:{5}",
                    _countryData.CountryName,
                    _countryData.Capital,
                    _countryData.CurrencyCode,
                    _countryData.Area,
                    _countryData.Population,
                    _countryData.FalgUrl);
                    
            }
        }
    }
}
