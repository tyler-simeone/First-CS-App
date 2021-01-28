using System;

namespace FirstCSApp.Interfaces
{
    public interface IElectricVehicle
    {
        public int BatteryKwh { get; set; }
        public double BatteryLife { get; set; }

        public void Charge()
        {
            
        }
    }
}
