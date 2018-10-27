using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sw_webutils.Models
{
    public class WeatherForecastData
    {
        private string _date;
        private string _day;
        private string _high;
        private string _low;
        private string _text;



        public string Date { get { return _date; } set { _date = value; } }
        public string Day { get { return _day; } set { _day = value; } }
        public string High { get { return _high; } set { _high = value; } }
        public string Low { get { return _low; } set { _low = value; } }
        public string Text { get { return _text; } set { _text = value; } }

    }
}
