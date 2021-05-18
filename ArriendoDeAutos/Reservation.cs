using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    public class Reservation
    {
        public int id { get; set; }
        public int days { get; set; }
        public double bill{ get; set;}
        public String month { get; set; }
        public String brand { get; set;}
        public String city { get; set;}
        enum Months
        {
            Enero = 1, Febrero = 2, Marzo = 3, Abril = 4, Mayo = 5, Junio = 6, Julio = 7, Agosto = 8, Septiembre = 9, Octubre = 10, Noviembre = 11, Diciembre = 12
        }
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
            bill = Billing(rPriceTotal, rDays);
        }
        public double Billing(double price, int days)
        {
            double bill = price * days;
            return bill;
        }
        public static Reservation MakeReservation(int rId, String rCity, String rBrand, double rPrice)
        {
            Reservation rev = new Reservation();
            Console.WriteLine("Cuantos dias quiere arrendar");
            int days = Int32.Parse(Console.ReadLine());
            Console.WriteLine("En que mes realizara el arriendo");
            String month = Console.ReadLine();
            double bill =  rev.Billing(rPrice, days);
            rev = new Reservation(rId, days, month, rCity, rBrand, bill);
            return rev;
        }
        public override string ToString()
        {
            string toString = "Id: " + id + " | Dias: " + days + " | Mes: " + month +  " | Ciudad: " + city + " | Marca: " + brand + " | Valor: " + Math.Round(bill);
            return toString;
        }
    }
}
