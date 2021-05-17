using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    public class Rent
    {
        int id, days, priceTotal;
        String month, brand, city;

        public Rent()
        {

        }
        public Rent(int id, int days, String month, String city, String brand, int priceTotal)
        {
            id = id;
            days = days;
            month = month;
            city = city;
            brand = brand;
            priceTotal = priceTotal;
        }

        public double valorTotal(double price, int days)
        {
            double x = price * days;
            return x;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
