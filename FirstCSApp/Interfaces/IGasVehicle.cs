using System;

namespace FirstCSApp.Interfaces
{
    public interface IGasVehicle
    {
        public double TankFillStatus { get; set; }
        public string EngineType { get; set; }

        public void Refill()
        {

        }
    }
}
