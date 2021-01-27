using System;

namespace FirstCSApp
{
    public class Rivian : IVehicle, IElectricVehicle
    {
        public Rivian(string name, int mileage, int kwh, int charge)
        {
            Name = name;
            Mileage = mileage;
            BatteryKwh = kwh;
            BatteryLife = charge;
        }

        public string Name { get; set; }
        public int Mileage { get; set; }
        public int BatteryKwh { get; set; }
        public int BatteryLife { get; set; } = 100;

        public void Drive()
        {
            Console.WriteLine("Starting Rivian....");
            Console.WriteLine("Vrroooommmm!");

            BatteryLife -= 30;

            Console.WriteLine("Current Battery Life: " + BatteryLife + "%");
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"{Name}'s current battery life {BatteryLife}%");
            Console.WriteLine("Charging....");

            BatteryLife += minutes * 2;

            Console.WriteLine("Updated Battery Life: " + BatteryLife + "%");
        }
    }
}
