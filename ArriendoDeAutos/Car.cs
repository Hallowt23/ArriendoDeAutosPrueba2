using System;
using System.Collections.Generic;
using System.Text;

namespace ArriendoDeAutos
{
    class Car
    {
        public int id;

         public String brand;

        public int pricePerDay;

        public String type;

        public Car(int carId, String carBrand, int carPricePerDay, String carType)
        {
            id = carId;

            brand = carBrand;

            pricePerDay = carPricePerDay;

            type = carType;

        }

        /*public String attributo { get; set; } ?? 
        string[] models = {"Audi", "Toyota", "Hyundai", "Subaru", "Mazda",
                "Suzuki", "Chevrolet", "Volkswagen", "Volvo"};
        string[] types = { "Sedan", "SUV", "Wagon", "Pickup", "Sport",
                "Compat", "Van", "Hatchback" };*/
    }
}
