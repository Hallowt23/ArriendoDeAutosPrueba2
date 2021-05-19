using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    public class Reservation
    {
        //TODO Atributos publicos para agilizar el codigo. En una version 2.0 estaran privados
        public int id { get; set; }
        public int days { get; set; }
        public int bill{ get; set;}
        public String month { get; set; }
        public String brand { get; set;}
        public String city { get; set;}
        public enum Months
        {
            Enero = 1, Febrero = 2, Marzo = 3, Abril = 4, Mayo = 5, Junio = 6, Julio = 7, Agosto = 8, Septiembre = 9, Octubre = 10, Noviembre = 11, Diciembre = 12
        }
        public Reservation()
        {

        }
        public Reservation(int rId, int rDays, String rMonth, String rCity, String rBrand, int rPriceTotal)
        {
            id = rId;
            days = rDays;
            month = rMonth;
            city = rCity;
            brand = rBrand;
            bill = rPriceTotal;
        }
        public int Billing(int price, int days)
        {
            int bill = price * days;
            return bill;
        }
        public static Reservation MakeReservation(int rId, String rCity, String rBrand, int rPrice)
        {
            Console.WriteLine("--Gestion de reserva--");
            Reservation rev = new Reservation();
            Console.WriteLine("Cuantos dias quiere arrendar");
            int days = Optimize.ValInt();
            Console.WriteLine("En que mes realizara el arriendo");
            int key = Optimize.ValInt();
            Months m = ((Months)key);
            String month = m.ToString();
            int bill =  rev.Billing(rPrice, days);
            rev = new Reservation(rId, days, month, rCity, rBrand, bill);
            return rev;
        }
        public override string ToString()
        {
            string toString = "Id: " + id + " | Dias: " + days + " | Mes: " + month +  " | Ciudad: " + city + " | Marca: " + brand + " | Valor: " + Convert.ToInt32(bill);
            return toString;
        }
    }
}
