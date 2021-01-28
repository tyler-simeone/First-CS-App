using System;
using FirstCSApp.Models;
using FirstCSApp.Interfaces;
using System.Collections.Generic;

namespace FirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Rivian rivian = new Rivian("Rivian R1T", 25, 100, 100);
            Tesla tesla = new Tesla("Tesla P100D", 50, 100, 100);
            Bronco bronco = new Bronco("Ford Bronco", 20, 100, "V8");

            List<IVehicle> availableVehicles = new List<IVehicle>()
            {
                rivian, tesla, bronco
            };

            Console.WriteLine("Choose a vehicle");

            int counter = 1;

            availableVehicles.ForEach(vehicle =>
            {
                Console.WriteLine($"{counter++}. {vehicle.Name}");
            });

            Console.Write("> ");

            string selectedVehicle = Console.ReadLine();

            if (selectedVehicle == "1")
            {
                rivian.Drive();
            }
            else if (selectedVehicle == "2")
            {
                tesla.Drive();
            }
            else if (selectedVehicle == "3")
            {
                bronco.Drive();
            }
        }
    }
}
