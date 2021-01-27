using System;

namespace FirstCSApp
{
    public interface IElectricVehicle
    {
        public int BatteryKwh { get; set; }
        public int BatteryLife { get; set; }

        public void Charge()
        {
            
        }
    }
}
