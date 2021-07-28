using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string LicensePlate { get; set; }
        public abstract int Wheels { get; }
        public abstract int MaxPassengers { get; }
        public abstract string GetDescription();

    }
    class Sedan : Vehicle
    {
        private int wheels = 4;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 5;
            }
        }
        public override string GetDescription()
        {
            return "Sedan License Plate: " + LicensePlate +
                " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers; ;
        }
        public override string ToString()
        {
            return "Sedan License Plate: " + LicensePlate + " VIN:" + VIN;
        }
    }
    public class Truck : Vehicle
    {
        public Truck(string vin, string license)
        {
            VIN = vin;
            LicensePlate = license;
        }

        private int wheels = 4;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 3;
            }
        }
        public override string ToString()
        {
            return "Truck License Plate: " + LicensePlate +
            " VIN " + VIN;

        }
        public override string GetDescription()
        {
            return "Truck License Plate: " + LicensePlate +
                " VIN: " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers; ;
        }

    }
}
