using System;
using System.Collections.Generic;
using System.Linq;

namespace ArriendoDeAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<Car> cars = new List<Car>();
            List<Office> offices = new List<Office>();
            string[] brands = {"Audi", "Toyota", "Hyundai", "Subaru", "Mazda",
                "Suzuki", "Chevrolet", "Volkswagen", "Volvo"};
            string[] types = { "Sedan", "SUV", "Wagon", "Pickup", "Sport",
                "Compat", "Van", "Hatchback" };
            string[] countries = { "Chile", "Brazil", "Argentina", "Mexico",
                "Spain", "Italy", "United states" };
            string[] cities = { "Santiago", "Sao paulo", "Buenos Aires",
                "Ciudad de Mexico", "Madrid", "Roma", "Texas" };
            int x = 0;
            for (int i = 0; i < 5; i++)
            {
                Car rentCar = new Car();
                int lb = brands.Length;
                int lt = types.Length;
                int rp = r.Next(1, 5);
                int rBrand = r.Next(0, lb);
                int rType = r.Next(0, lt);
                rentCar.id = i;
                rentCar.brand = brands[rBrand];
                rentCar.type = types[rType];
                int range = 8000;
                rentCar.pricePerDay = range * rp;
                //cars.Add(new Car(rentCar.id, rentCar.brand, rentCar.pricePerDay, rentCar.type));
                cars.Add(rentCar);
                //rentCar.toString();

            }
            foreach (var obj in cars)
            {
                Console.WriteLine(obj.id + ", " + obj.brand + ", " + obj.type + ", " + obj.pricePerDay);
                
                //Console.Write();
            }

            /*
            for (int i = 0; i < 5; i++)
            {
                int x = 0;
                String t = "hola";
                Office office = new Office(x, t,  t, t);
                office.id = i;
                office.country = countries[i];
                office.city = cities[i];
                int range = (i + 3) * 570;
                office.address = office.country + ", " + office.city + ", " + range;
                Console.WriteLine(office.address);

                Console.ReadLine();
                //var dump = ObjectDumper.Dump(office);
            }*/
            while (x == 0)
            {
                x = 1;
                Console.WriteLine("Bye!");
            }
        } 
    }
}
