using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    public class Office
    {
        public int id;
        public String address, city, country;

        public Office()
        {

        }
        public Office(int Id, String country, String city, String address)
        {
            id = id;
            country = country;
            city = city;
            address = address;
        }
        public void toString()
        {
            Console.WriteLine("Oficina N°:{0}, ubicada en: {1}, {2}, {3}", id, country, city, address);
        }
    }
}
