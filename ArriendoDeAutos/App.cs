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
            int iterator = 30;
            int selectedCar = 100;
            int selectedOffice = 200;
            String key, rentTicket;
            bool app = true;

            Console.WriteLine("--Cargando Datos--");
            System.Threading.Thread.Sleep(1500);
            //Database
            //Insertar datos para tener autos que arrendar.
            for (int i = 0; i < iterator; i++)
            {
                var car = Car.DataCar(i);
                cars.Add(car);
                //car.ToString();
                if (i < 7)
                {
                    var office = Office.DataOffice(i);
                    offices.Add(office);
                    //office.ToString();
                }
                Console.Clear();
                int z = i * 3;
                Console.Write(z + "%");
                int x = 10;
                System.Threading.Thread.Sleep(x);
            }
            Console.WriteLine("--Hertz.Console--");
            Console.WriteLine("--TFM@LAN@ArriendoDeAutos@Prueba2--");

            while (app)
            {
                Console.Clear();
                Console.WriteLine("---Menu---");
                Console.WriteLine("1-Seleccionar Auto");
                Console.WriteLine("2-Seleccionar Oficina");
                Console.WriteLine("3-Realizar Reserva");
                Console.WriteLine("4-Ver Reserva");
                Console.WriteLine("5-Salir");
                Console.WriteLine("---------");

                try
                {
                    //TODO validador de key*
                    key = Console.ReadLine();
                    switch (key)
                    {
                        case "1":
                            //Vista de autos
                            Console.WriteLine("--Autos Disponibles--");
                            foreach (var obj in cars)
                            {
                                Console.WriteLine(obj.ToString());
                            }
                            Console.WriteLine("--Escriba el id del auto que desea arrendar--");
                            selectedCar = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("--Auto seleccionado--");
                            Console.WriteLine(cars[selectedCar].ToString());
                            Console.ReadLine();
                            break;


                        case "2":
                            //Vista de oficinas
                            Console.WriteLine("--Oficinas Hertz--");
                            foreach (var obj in offices)
                            {
                                Console.WriteLine(obj.ToString());
                            }
                            Console.WriteLine("--Escriba el id de la oficina donde retirara el auto--");
                            selectedOffice = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("--Auto seleccionado--");
                            Console.WriteLine(offices[selectedOffice].ToString());
                            Console.ReadLine();
                            break;

                            /*
                        case "3":
                            String brand = "";
                            String city = "";
                            double price = 0;
                            //Realizar reserva
                            for (int i = 0; i < iterator; i++)
                            {
                                //Seteo Auto en Rent
                                if (cars[i].id == sC)
                                {

                                    brand = cars[i].brand();
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
                            break;*/


                        case "4":
                            //TODO Setear el ticket del arriendo
                            Console.WriteLine("Hello im 4");
                            break;


                        case "5":
                           app = false;
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

                } catch (InvalidCastException e) {

                    
                }
               

            }
        }
    }
}
