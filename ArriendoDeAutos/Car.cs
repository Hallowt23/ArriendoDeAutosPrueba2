using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArriendoDeAutos
{
    class Car
    {
        //TODO Atributos publicos para agilizar el codigo. En una version 2.0 estaran privados para cumplir con buenas practicas
        public static List<Car> cars = new List<Car>();
        static Random r = new Random();
        public int id { get; set; }
        public int pricePerDay { get; set; }
        public String brand { get; set; }
        public String type { get; set; }
        static string[] brands = {"Audi", "Toyota", "Hyundai", "Subaru", "Mazda", "Mercedez Benz",
                "Suzuki", "Chevrolet", "Volkswagen", "Volvo", "Ford", "BMW", "Nissan"};
        static string[] types = { "Sedan", "SUV", "Wagon", "Pickup", "Sport", "Roadster",
                "Compat", "Van", "Hatchback", "Urban", "Coupe", "Crossover" };
        public Car()
        {

        }
        public Car(int carId, String carBrand, int carPricePerDay, String carType)
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
            int rangePrice = r.Next(1,11);
            int basePrice = 9150;
            int price = basePrice * rangePrice;
            car = new Car(index, brands[rBrand], price, types[rType]);
            cars.Add(car);
            return car;
        }
        public override string ToString()
        {
            string toString = "Id: " + id + " | Marca: " + brand + " | Tipo: " +type + " | Valor: " + pricePerDay + " por día.";
            return toString;
        }
        public Car IsNullOrEmpty(Car car)
        {
            return car;
        }
        //LINQ
        public void LinqDescending()
        {
            Console.WriteLine("Valores Descendientes");
            var queryDe = from car in cars
                          orderby car.pricePerDay descending
                          select car;
            foreach (var obj in queryDe)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        public void LinqAscending()
        {
            Console.WriteLine("Valores Ascendientes");
            var queryAsc = from car in cars
                           orderby car.pricePerDay ascending
                           select car;
            foreach (var obj in queryAsc)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        public void LinqAmmount()
        {
            Console.WriteLine("Valor Menor a");
            int ammount = Optimize.ValInt();
            var queryPBase = from car in cars
                             where car.pricePerDay <= ammount
                             orderby car.id
                             select (car);
            foreach (var obj in queryPBase)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        public void ListView()
        {
            foreach (var obj in cars)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
