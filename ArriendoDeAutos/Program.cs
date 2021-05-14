using System;

namespace ArriendoDeAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = 0;
            string[] brands = {"Audi", "Toyota", "Hyundai", "Subaru", "Mazda",
                "Suzuki", "Chevrolet", "Volkswagen", "Volvo"};
            string[] types = { "Sedan", "SUV", "Wagon", "Pickup", "Sport",
                "Compat", "Van", "Hatchback" };
            string[] countries = { "Chile", "Brazil", "Argentina", "Mexico", "Spain", "Italy", "United states" };
            string[] cities = { "Santiago", "Sao paulo", "Buenos Aires", "Ciudad de Mexico", "Madrid", "Roma", "Texas" };

            while (x == 0)
            {
                for (int i = 0; i < 10; i ++)
                {
                    int lb = brands.Length;
                    int lt = types.Length;
                    int rp = r.Next(1, 5);
                    int rBrand = r.Next(0, lb);
                    int rType = r.Next(0, lt);
                    Car car = new Car();
                    car.id = i;
                    car.brand = brands[rBrand];
                    car.type = types[rType];
                    int range = 8000;
                    car.pricePerDay = range * rp;
                    Console.WriteLine(car.brand);
                    //Console.ReadLine();
                }
                for (int i = 0; i < 5; i++)
                {
                    //int lco = countries.Length;
                    //int lci = cities.Length;
                    //int rCountry = r.Next(0, lco);
                    //int rCity = r.Next(0, lci);
                    Office office = new Office();
                    office.id = i;
                    office.country = countries[i];
                    office.city = cities[i];
                    int range = (i + 3) * 570;
                    office.address = office.country+", "+office.city+", "+range;
                    Console.WriteLine(office.address);
                    Console.ReadLine();
                }
                Office office1 = new Office();
                Rent ren1 = new Rent();
                x = 1;
                Console.WriteLine("Bye!");
            }
        } 
    }
}
