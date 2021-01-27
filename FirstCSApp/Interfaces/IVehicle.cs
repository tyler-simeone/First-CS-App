using System;

namespace FirstCSApp
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
