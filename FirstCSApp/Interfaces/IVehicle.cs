using System;

namespace FirstCSApp.Interfaces
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public int Mileage { get; set; }

        public virtual void Drive()
        {
            
        }
    }
}
