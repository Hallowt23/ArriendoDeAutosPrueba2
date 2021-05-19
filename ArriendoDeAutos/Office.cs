using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    public class Office
    {
        //TODO Atributos publicos para agilizar el codigo. En una version 2.0 estaran privados para cumplir con buenas practicas
        public int id { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String country { get; set; }
        public static string[] countries = { "Chile", "Brazil", "Argentina", "Mexico",
                "Spain", "Italy", "United states" };
        public static string[] cities = { "Santiago", "Sao paulo", "Buenos Aires",
                "Ciudad de Mexico", "Madrid", "Roma", "Texas" };
        public Office()
        {

        }
        public Office(int officeId, String officeCountry, String officeCity, String officeAddress)
        {
            id = officeId;
            country = officeCountry;
            city = officeCity;
            address = officeAddress;
        }
        public static Office DataOffice(int index)
        {
            Office office = new Office();
            int range = (index + 3) * 570;
            String address = "Hertz.rd " + range;
            office = new Office(index, countries[index], cities[index], address);
            return office;
        }
        public override string ToString()
        {
            string toString = "Id: " + id + " | Pais: " + country + " | Ciudad: " + city + " | Direccion: " + address;
            return toString;
        }
    }
}
