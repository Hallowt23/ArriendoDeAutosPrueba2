using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    class Car
    {
        static Random r = new Random();
        private int id { get; set; }
        private double pricePerDay { get; set; }
        private String brand { get; set; }
        private String type { get; set; }

        static string[] brands = {"Audi", "Toyota", "Hyundai", "Subaru", "Mazda", "Mercedez Benz",
                "Suzuki", "Chevrolet", "Volkswagen", "Volvo", "Ford", "BMW", "Nissan"};
        static string[] types = { "Sedan", "SUV", "Wagon", "Pickup", "Sport", "Roadster",
                "Compat", "Van", "Hatchback", "Urban", "Coupe", "Crossover" };

        public Car()
        {

        }
        public Car(int carId, String carBrand, double carPricePerDay, String carType)
        {
            id = carId;
            brand = carBrand;
            pricePerDay = carPricePerDay;
            type = carType;
        }
        public static Car DataCar(int index)
        {
            Car car = new Car();
            int rBrand = r.Next(0, brands.Length);
            int rType = r.Next(0, types.Length);
            int rangePrice = r.Next(1, 7);
            int basePrice = 8250;
            double price = basePrice * rangePrice;
            car = new Car(index, brands[rBrand], price, types[rType]);
            return car;
        }
        public override string ToString()
        {
            string toString = "Id: " + id + " | Marca: " + brand + " | Tipo: " +type + " | Valor: " + pricePerDay + " por día.";
            return toString;
        }
    }
}
