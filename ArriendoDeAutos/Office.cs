using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    public class Office
    {
        public int id { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String country { get; set; }

        /*public bool rentAvailable { get; set; }
        int lco = countries.Length;
        int lci = cities.Length;
        int rCountry = r.Next(0, lco);
        int rCity = r.Next(0, lci);*/

        public Office(int officeId, String officeAddress, String officeCountry, String officeCity)
        {
            id = officeId;

            address = officeAddress;

            country = officeCountry;

            city = officeCity;

        }
    }
}
