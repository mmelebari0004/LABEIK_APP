using System;
using System.Collections.Generic;
using System.Text;

namespace Hachathon2
{ 
    public class CountriesViewModel
    {
        public List<string> CountriesList;
       

        public CountriesViewModel()
        {
            CountriesList = new List<string>();
            fillData();

        }

        private void fillData()
        {
            string country1 = "Saudi Arabia";
            CountriesList.Add(country1);

            string country2 = "Egpt";
            CountriesList.Add(country2);
        }
    }
}
