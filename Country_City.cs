using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenThanhPho_TH2
{
    internal class Country_City
    {
        string country,city;
        public Country_City(string country, string city)
        {
            this.country = country;
            this.city = city;
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}
