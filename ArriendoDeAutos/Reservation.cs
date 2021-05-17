using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    public class Reservation
    {
        private int id { get; set; }
        private int days { get; set; }
        private double priceTotal { get; set;}
        private String month { get; set; }
        private String brand { get; set;}
        private String city { get; set;}
        public Reservation()
        {

        }
        public Reservation(int rId, int rDays, String rMonth, String rCity, String rBrand, double rPriceTotal)
        {
            id = rId;
            days = rDays;
            month = rMonth;
            city = rCity;
            brand = rBrand;
            priceTotal = ValorTotal(rPriceTotal, rDays);
        }
        public double ValorTotal(double price, int days)
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
