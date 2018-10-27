using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace sw_webutils.Models
{
    public class CountryData
    {
        private string _countryname;
        private string _capital;
        private string _population;
        private string _area;
        private string _currencycode;
        private string _flagurl;

        //When input country is empty
        [Required(ErrorMessage = "Please enter a city.")]
        public string CountryName { get { return _countryname; } set { _countryname = value; } }


        public string Capital { get { return _capital; } set { _capital = value; } }
        public string Population { get { return _population; } set { _population = value; } }
        public string Area { get { return _area; } set { _area = value; } }
        public string CurrencyCode { get { return _currencycode; } set { _currencycode = value; } }
        public string FalgUrl { get { return _flagurl; } set { _flagurl = value; } }

        public CountryData()
        {
            CountryName = null;
            Capital = null;

        }
    }
}
