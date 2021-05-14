using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    class Car
    {
        public int id;
        public double pricePerDay;
        public String brand, type;

        public Car()
        {

        }
        public Car(int id, String brand, double pricePerDay, String type)
        {
            //Car car = new Car(id, brand, pricePerDay, type);
            id = id;
            brand = brand;
            pricePerDay = pricePerDay;
            type = type;

        }
        public void toString()
        {
            Console.WriteLine("El vehiculo N°:{0}, {1}, {2}, {3}", id, brand, type, pricePerDay);
        }
    }
}
