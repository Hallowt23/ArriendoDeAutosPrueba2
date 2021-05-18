using System;
using System.Collections.Generic;
using System.Linq;

namespace ArriendoDeAutos
{
    class App
    {
        //TODO validador de key y rut
        static void Main(string[] args)
        {
            //Variables / Instancias
            Random r = new Random();
            List<Car> cars = new List<Car>();
            List<Office> offices = new List<Office>();
            Reservation rev = null;
            Car selectedCar = null;
            Office selectedOffice = null;
            int key;
            int iterator = 30;
            int rut = 0;
            bool app = true;
            bool login = false;
            String mAL = "";

            //"Database" Loading
            Console.WriteLine("<Lan>");
            Console.WriteLine("--Cargando Datos--");
            Console.WriteLine("</Lan>");
            System.Threading.Thread.Sleep(1250);
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
            Console.WriteLine("--Hertz.ConsoleApp--");
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
                    if (login == false)
                    {

                        Console.Clear();
                        Console.WriteLine("** Identificacion de usuario **");
                        Console.WriteLine("** Ingrese Rut **");
                        rut = Optimize.ValInt();
                        Console.WriteLine("** Ingrese Iniciales **");
                        mAL = Optimize.ValString();
                        login = true;
                    } else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione una opcion");
                        key = Optimize.ValInt();
                        switch (key)
                        {
                            case 1:
                                //Vista seleccion de auto
                                Console.Clear();
                                Console.WriteLine("--Autos Disponibles--");
                                Console.WriteLine("Seleccione una opcion");
                                Console.WriteLine("1-Precio Descendiente | 2-Precio Ascendiente | 3-Precio Desde | 4-Lista completa");
                                key = Int32.Parse(Console.ReadLine());
                                try
                                {
                                    Car LINQ = new Car();
                                    switch (key)
                                    {
                                        case 1:
                                            LINQ.LinqDescending();
                                            break;
                                        case 2:
                                            LINQ.LinqAscending();
                                            break;
                                        case 3:
                                            LINQ.LinqAmmount();
                                            break;
                                        case 4:
                                            LINQ.ListView();
                                            break;
                                        default:
                                            return;
                                    }
                                } catch (InvalidCastException e)
                                {
                                    Console.WriteLine(e);
                                }
                                Console.WriteLine("--Escriba el Id del auto que desea arrendar--");
                                key = Optimize.ValInt();
                                Console.WriteLine("--Auto agregado--");
                                Console.WriteLine(cars[key].ToString());
                                selectedCar = cars[key];
                                Console.ReadLine();
                                break;

                            case 2:
                                //Vista seleccion de oficina
                                Console.Clear();
                                Console.WriteLine("--Oficinas Hertz--");
                                foreach (var obj in offices)
                                {
                                    Console.WriteLine(obj.ToString());
                                }
                                Console.WriteLine("--Escriba el Id de la oficina donde retirara el auto-");
                                key = Optimize.ValInt();
                                Console.WriteLine("--Oficina agregada--");
                                Console.WriteLine(offices[key].ToString());
                                selectedOffice = offices[key];
                                Console.ReadLine();
                                break;

                            case 3:
                                //Vista gestion de reserva
                                Console.Clear();
                                if ( selectedCar == null || selectedOffice == null )
                                {
                                    Console.WriteLine("No hay Auto o Officina seleccionada");
                                    System.Threading.Thread.Sleep(750);
                                    break;
                                }
                                rev = Reservation.MakeReservation(rut, selectedOffice.city, selectedCar.brand, selectedCar.pricePerDay);
                                Console.WriteLine("--Reserva generada--");
                                Console.WriteLine(rev.ToString());
                                Console.ReadLine();
                                break;
                            
                            case 4:
                                //Vista de la reserva (Boleta/Ticket)
                                Console.Clear();
                                if ( rev == null )
                                {
                                    Console.WriteLine("No ha generado ninguna reserva");
                                    System.Threading.Thread.Sleep(750);
                                    break;
                                }
                                Console.WriteLine("La informacion de su reserva es la siguiente");
                                Console.WriteLine(rev.ToString());
                                Console.ReadLine();
                                break;

                            case 5:
                                //Cerrar App
                                app = false;
                                Console.WriteLine("--Cerrando--");
                                Environment.Exit(0);
                                break;

                            case 6:
                                //Logout
                                login = false;
                                break;

                            default:
                                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                                Console.WriteLine("Utilice un numero entre 1 y 5");
                                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                                System.Threading.Thread.Sleep(750);
                                break;
                        }
                    }
                } catch (InvalidCastException e) {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
