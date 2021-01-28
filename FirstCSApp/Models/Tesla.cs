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
        public double BatteryLife { get; set; } = 100;

        public void Drive()
        {
            Console.WriteLine("Starting Tesla....");
            Console.WriteLine("Zoooommmm!");

            BatteryLife -= 30;

            Console.WriteLine("\nCurrent Battery Life: " + BatteryLife + "%");
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
                    break;

                case "2":
                    BatteryLife *= 1.50;

                    if (BatteryLife > 100)
                    {
                        BatteryLife = 100;
                    }

                    Console.WriteLine("Updated Battery Life: " + BatteryLife + "%");
                    break;

                case "3":
                    BatteryLife *= 1.75;

                    if (BatteryLife > 100)
                    {
                        BatteryLife = 100;
                    }

                    Console.WriteLine("Updated Battery Life: " + BatteryLife + "%");
                    break;

                case "4":
                    BatteryLife *= 2;

                    if (BatteryLife > 100)
                    {
                        BatteryLife = 100;
                    }

                    Console.WriteLine("Updated Battery Life: " + BatteryLife + "%");
                    break;
            }
        }
    }
}
