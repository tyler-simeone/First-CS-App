using System;
using FirstCSApp.Models;

namespace FirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Rivian rivian = new Rivian("Rivian R1T", 25, 100, 100);
            Tesla tesla = new Tesla("Tesla P100D", 50, 100, 100);
            Bronco bronco = new Bronco("Ford Bronco", 20, 100, "V8");

            Console.WriteLine("Choose a vehicle");
            Console.WriteLine("1. Rivian");
            Console.WriteLine("2. Tesla");
            Console.WriteLine("3. Bronco");
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

            if (selectedVehicle == "3")
            {
                Console.WriteLine("Would you like to refill?");
            }
            else
            {
                Console.WriteLine("Would you like to recharge?");
            }
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("> ");


            string refill = Console.ReadLine();

            if (refill == "1")
            {
                if (selectedVehicle == "1")
                {
                    rivian.Charge();
                }
                else if (selectedVehicle == "2")
                {
                    tesla.Charge();
                }else if (selectedVehicle == "3")
                {
                    bronco.Refill();
                }
            }
        }
    }
}
