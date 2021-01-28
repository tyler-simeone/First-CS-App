using System;
using FirstCSApp.Interfaces;

namespace FirstCSApp.Models
{
    public class Bronco : IVehicle, IGasVehicle
    {
        public Bronco(string name, int mileage, double tankFillAmt, string engineType)
        {
            Name = name;
            Mileage = mileage;
            TankFillStatus = tankFillAmt;
            EngineType = engineType;
        }

        public string Name { get; set; }
        public int Mileage { get; set; }
        public double TankFillStatus { get; set; }
        public string EngineType { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Starting {Name}....");
            Console.WriteLine("Vrroooommmm!");

            TankFillStatus -= 30;

            Console.WriteLine("Current Tank Status: " + TankFillStatus+ "%");
        }

        public void Refill()
        {
            Console.WriteLine("How much would you like to put in?");
            Console.WriteLine("1. $10");
            Console.WriteLine("2. $20");
            Console.WriteLine("3. $30");
            Console.WriteLine("4. $40");
            Console.Write("> ");

            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    TankFillStatus *= 1.25;

                    if (TankFillStatus > 100)
                    {
                        TankFillStatus = 100;
                    }

                    Console.WriteLine($"Tank filled up to {TankFillStatus}%");
                    break;

                case "2":
                    TankFillStatus *= 1.50;

                    if (TankFillStatus > 100)
                    {
                        TankFillStatus = 100;
                    }

                    Console.WriteLine($"Tank filled up to {TankFillStatus}%");
                    break;

                case "3":
                    TankFillStatus *= 1.75;

                    if (TankFillStatus > 100)
                    {
                        TankFillStatus = 100;
                    }

                    Console.WriteLine($"Tank filled up to {TankFillStatus}%");
                    break;

                case "4":
                    TankFillStatus *= 2;

                    if (TankFillStatus > 100)
                    {
                        TankFillStatus = 100;
                    }

                    Console.WriteLine($"Tank filled up to {TankFillStatus}%");
                    break;
            }

        }
    }
}
