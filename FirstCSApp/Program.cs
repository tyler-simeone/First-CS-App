using System;

namespace FirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Rivian rivian = new Rivian("Rivian R1T", 25, 100, 100);
            Tesla tesla = new Tesla("Tesla P100D", 50, 100, 100);

            Console.WriteLine("Choose a vehicle");
            Console.WriteLine("1. Rivian");
            Console.WriteLine("2. Tesla");

            string selectedVehicle = Console.ReadLine();

            if (selectedVehicle == "1")
            {
                rivian.Drive();
            }
            else if (selectedVehicle == "2")
            {
                tesla.Drive();
            }

            Console.WriteLine("Would you like to recharge?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            string chargeEV = Console.ReadLine();

            if (chargeEV == "1")
            {
                if (selectedVehicle == "1")
                {
                    rivian.Charge(10);
                }
                else if (selectedVehicle == "2")
                {
                    tesla.Charge(10);
                }
            }
        }
    }
}
