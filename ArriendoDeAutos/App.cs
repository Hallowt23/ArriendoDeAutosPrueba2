using System;
using System.Collections.Generic;
using System.Linq;

namespace ArriendoDeAutos
{
    class App
    {
        static void Main(string[] args)
        {
            //Data / Instancias
            Random r = new Random();
            List<Car> cars = new List<Car>();
            List<Office> offices = new List<Office>();
            Reservation rev = null;
            Car selectedCar = null;
            Office selectedOffice = null;
            int iterator = 30;
            int ammount = 0;
            int rut = 0;
            int key = 0;
            bool app = true;
            //TODO CUANDO ESTE LISTO --> False
            bool login = true;
            String mAL = "";

            Console.WriteLine("--Cargando Datos--");
            System.Threading.Thread.Sleep(1250);
            //Database / Loading
            for (int i = 0; i < iterator; i++)
            {
                var car = Car.DataCar(i);
                cars.Add(car);
                if (i < Office.countries.Length)
                {
                    var office = Office.DataOffice(i);
                    offices.Add(office);
                }
                Console.Clear();
                int z = i * 3;
                Console.Write(z + "%");
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine("--Hertz.Console--");
            Console.WriteLine("--TomasFernandez@ArriendoDeAutos@Prueba2--");

            while (app)
            {
                Console.Clear();
                Console.WriteLine("---Menu---");
                Console.WriteLine("1-Seleccionar Auto");
                Console.WriteLine("2-Seleccionar Oficina");
                Console.WriteLine("3-Realizar Reserva");
                Console.WriteLine("4-Ver Reserva");
                Console.WriteLine("5-Salir");
                if (login)
                {
                    Console.WriteLine("6-Logout");
                    Console.WriteLine("--ID:"+mAL+"---");
                } else
                {
                    Console.WriteLine("No-User");
                    Console.WriteLine("---------");
                }
                try
                {
                    //TODO validador de key y rut
                    //Console.WriteLine("--Ingrese su Rut--");
                    if (login == false)
                    {
                        Console.WriteLine("Ingrese Rut");
                        rut = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese iniciales");
                        mAL = Console.ReadLine();
                        login = true;
                    } else
                    {
                        Console.WriteLine("Seleccione una opcion");
                        key = Int32.Parse(Console.ReadLine());
                        switch (key)
                        {

                            case 1:
                                
                                //Vista de autos
                                Console.WriteLine("--Autos Disponibles--");
                                Console.WriteLine("Seleccione una opcion");
                                //key = Int32.Parse(Console.ReadLine());

                                //Modulo LINQ
                                Console.WriteLine("1-Valor Descendiente");
                                var queryDe = from car in cars
                                    orderby car.pricePerDay descending
                                    select car;
                                foreach (var obj in queryDe)
                                {
                                    Console.WriteLine(obj.ToString());
                                }

                                Console.WriteLine("2-Valor Ascendiente");
                                var queryAsc = from car in cars
                                              orderby car.pricePerDay descending
                                              select car;
                                foreach (var obj in queryAsc)
                                {
                                    Console.WriteLine(obj.ToString());
                                }

                                Console.WriteLine("3-Valor Desde");
                                ammount = Int32.Parse(Console.ReadLine());
                                var queryPBase = from car in cars
                                              where car.pricePerDay >= ammount
                                              orderby car.pricePerDay descending
                                              select (car);
                                foreach (var obj in queryPBase)
                                {
                                    Console.WriteLine(obj.ToString());
                                }

                                Console.WriteLine("4-Todos los Autos");
                                foreach (var obj in cars)
                                {
                                    Console.WriteLine(obj.ToString());
                                }


                                Console.WriteLine("--Seleccione por id su auto--");
                                key = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("--Auto seleccionado--");
                                Console.WriteLine(cars[key].ToString());
                                selectedCar = cars[key];
                                Console.ReadLine();
                                break;


                            case 2:
                                //Vista de oficinas
                                Console.WriteLine("--Oficinas Hertz--");
                                foreach (var obj in offices)
                                {
                                    Console.WriteLine(obj.ToString());
                                }
                                Console.WriteLine("--Selecciona por id una oficina-");
                                key = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("--Auto seleccionado--");
                                Console.WriteLine(offices[key].ToString());
                                selectedOffice = offices[key];
                                Console.ReadLine();
                                break;

                            
                            case 3:
                                //Vista de reserva
                                if ( selectedCar == null || selectedOffice == null )
                                {
                                    Console.WriteLine("No hay Autos o Officina seleccionada");
                                    System.Threading.Thread.Sleep(500);
                                    break;
                                }
                                rev = Reservation.MakeReservation(rut, selectedOffice.city, selectedCar.brand, selectedCar.pricePerDay);
                                Console.WriteLine("--Reserva generada--");
                                Console.WriteLine(rev.ToString());
                                Console.ReadLine();
                                break;
                            

                            case 4:
                                //Vista de la informacion de reserva
                                Console.WriteLine("La informacion de su reserva es la siguiente");
                                if ( rev == null )
                                {
                                    break;
                                }
                                rev.ToString();
                                Console.ReadLine();
                                break;


                            case 5:
                                app = false;
                                Console.WriteLine("--Cerrando--");
                                Environment.Exit(0);
                                break;

                            case 6:
                                login = false;
                                break;


                            default:
                                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                                Console.WriteLine("Utilice un numero entre 1 y 5");
                                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                                //x = Int32.Parse(Console.ReadLine());
                                break;
                        }
                    }


                } catch (InvalidCastException e) {

                    
                }
               

            }
        }
    }
}
