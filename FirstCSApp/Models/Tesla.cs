using System;
using FirstCSApp.Interfaces;

namespace FirstCSApp
{
    public class Tesla : IVehicle, IElectricVehicle
    {
        public Tesla(string name, int mileage, int kwh, double charge)
        {
            Name = name;
            Mileage = mileage;
            BatteryKwh = kwh;
            BatteryLife = charge;
        }

        public string Name { get; set; }
        public int Mileage { get; set; }
        public int BatteryKwh { get; set; }
        public double BatteryLife { get; set; }

        public void Drive()
        {
            Console.WriteLine("Starting Tesla....");
            Console.WriteLine("Zoooommmm!");

            BatteryLife -= 30;

            Console.WriteLine("\nCurrent Battery Life: " + BatteryLife + "%");
            Console.WriteLine("Would you like to recharge?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("> ");

            string recharge = Console.ReadLine();

            if (recharge == "1")
            {
                Charge();
            }
        }

        public void Charge()
        {
            Console.WriteLine("How much time would you like to charge?");
            Console.WriteLine("1. 10 minutes");
            Console.WriteLine("2. 20 minutes");
            Console.WriteLine("3. 30 minutes");
            Console.WriteLine("4. 40 minutes");
            Console.Write("> ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BatteryLife *= 1.25;

                    if (BatteryLife > 100)
                    {
                        BatteryLife = 100;
                    }

                    Console.WriteLine("Updated Battery Life: " + BatteryLife + "%");
                    Console.WriteLine($"\n1. Go for another drive?");
                    Console.WriteLine($"2. Exit");
                    Console.Write("> ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Drive();
                    }

                    break;

                case "2":
                    BatteryLife *= 1.50;

                    if (BatteryLife > 100)
                    {
                        BatteryLife = 100;
                    }

                    Console.WriteLine("Updated Battery Life: " + BatteryLife + "%");
                    Console.WriteLine($"\n1. Go for another drive?");
                    Console.WriteLine($"2. Exit");
                    Console.Write("> ");
                    string choiceTwo = Console.ReadLine();

                    if (choiceTwo == "1")
                    {
                        Drive();
                    }

                    break;

                case "3":
                    BatteryLife *= 1.75;

                    if (BatteryLife > 100)
                    {
                        BatteryLife = 100;
                    }

                    Console.WriteLine("Updated Battery Life: " + BatteryLife + "%");
                    Console.WriteLine($"\n1. Go for another drive?");
                    Console.WriteLine($"2. Exit");
                    Console.Write("> ");
                    string choiceThree = Console.ReadLine();

                    if (choiceThree == "1")
                    {
                        Drive();
                    }

                    break;

                case "4":
                    BatteryLife *= 2;

                    if (BatteryLife > 100)
                    {
                        BatteryLife = 100;
                    }

                    Console.WriteLine("Updated Battery Life: " + BatteryLife + "%");
                    Console.WriteLine($"\n1. Go for another drive?");
                    Console.WriteLine($"2. Exit");
                    Console.Write("> ");
                    string choiceFour = Console.ReadLine();

                    if (choiceFour == "1")
                    {
                        Drive();
                    }

                    break;
            }
        }
    }
}
