using System;
using System.Collections.Generic;
using System.Linq;

namespace ArriendoDeAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data / Instancias
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
            //Cambiar X y Z 
            int x = 7;
            int sC = 100;
            int sO = 200;
            String z, rT;
            bool t = true;
            String brand = "";
            String city = "";
            double price = 0;

            //DataBase
            //Insertar datos para tener autos que arrendar.
            for (int i = 0; i < x; i++)
            {
                Car car = new Car();
                int lb = brands.Length;
                int lt = types.Length;
                int rp = r.Next(1, 5);
                int rBrand = r.Next(0, lb);
                int rType = r.Next(0, lt);
                car.id = i;
                car.brand = brands[rBrand];
                car.type = types[rType];
                int range = 8000;
                car.pricePerDay = range * rp;
                cars.Add(car);
                //rentCar.toString();
            }
            //Insertar datos para seleccionar una oficina donde arrendar.
            for (int i = 0; i < x; i++)
            {
                Office office = new Office();
                office.id = i;
                office.country = countries[i];
                office.city = cities[i];
                int range = (i + 3) * 570;
                office.address =  "Hertz.rd " + range;
                offices.Add(office);
            }

            while (x != 5)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1-Seleccionar Auto");
                Console.WriteLine("2-Seleccionar Oficina");
                Console.WriteLine("3-Realizar Reserva");
                Console.WriteLine("4-Ver Reserva");
                Console.WriteLine("5-Salir");
                Console.WriteLine("---------");

                //TODO validador de key*
                z = Console.ReadLine();

                switch (z)
                {
                    case "1":
                        //Vista de autos
                        Console.WriteLine("Autos disponibles");
                        Console.WriteLine("Id / Marca / Tipo / Precio por dia");
                        foreach (var obj in cars)
                        {
                            Console.WriteLine(obj.id + "- " + obj.brand + ", " + obj.type + ", " + obj.pricePerDay);
                        }
                        Console.WriteLine("Escriba el id del auto que desea arrendar");
                        sC = Int32.Parse(Console.ReadLine());
                        break;


                    case "2":
                        //Vista de oficinas
                        Console.WriteLine("Oficinas donde podra retirar el vehiculo");
                        Console.WriteLine("Id / Pais / Ciudad / Direccion");
                        foreach (var obj in offices)
                        {
                            Console.WriteLine(obj.id + "- " + obj.country + ", " + obj.city + ", " + obj.address);
                        }
                        Console.WriteLine("Escriba el id de la oficina donde retirara el auto");
                        sO = Int32.Parse(Console.ReadLine());
                        break;


                    case "3":
                        //Realizar reserva
                        for (int i = 0; i < x; i++)
                        {
                            //Seteo Auto en Rent
                            if (cars[i].id == sC)
                            {
                                brand = cars[i].brand;
                                price = cars[i].pricePerDay;
                            }
                            else { }
                            //Seteo Oficina en Rent
                            if (offices[i].id == sO)
                            {
                                city = offices[i].city;
                            }
                            else { }
                            //TODO Setear Rent
                        }
                        Console.WriteLine(brand);
                        Console.WriteLine(city);
                        //rT = Console.ReadLine();
                        break;


                    case "4":
                        Console.WriteLine("Hello im 4");
                        break;


                    case "5":
                        x = 0;
                        Console.WriteLine("Cerrando");
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                        Console.WriteLine("Utilice un numero entre 1 y 5");
                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                        //x = Int32.Parse(Console.ReadLine());
                        break;
                }

            }
        } 
    }
}
