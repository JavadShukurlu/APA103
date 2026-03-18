using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Truck:Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }

        public Truck()
        {
            
        }
        public Truck( double cargocapacity):this()
        {
            CargoCapacity = cargocapacity;
        }
        public Truck(double cargocapacity,int axlecount):this(cargocapacity)
        {
            AxleCount = axlecount;
        }
        public Truck(double cargocapacity,int axlecount,double currentload):this(cargocapacity,axlecount)
        {
            CurrentLoad = currentload;
        }

        public Truck(string brand) : base(brand)
        {

        }
        public Truck(string brand, string model) : base(brand, model)
        {

        }
        public Truck(string brand, string model, int year) : base(brand, model, year)
        {

        }
        public Truck(string brand, string model, int year, string platenumber) : base(brand, model, year, platenumber)
        {

        }
        public Truck(string brand, string model, int year, string platenumber, double fuelLevel) : base(brand, model, year, platenumber, fuelLevel)
        {

        }
        public Truck(string brand, string model, int year, string platenumber, double fuelLevel, int maxspeed) : base(brand, model, year, platenumber, fuelLevel, maxspeed)
        {

        }
        public void LoadCargo(double weight)
        {
            if ((CurrentLoad+weight) > CargoCapacity)
                Console.WriteLine("Yuklenen tutum umumi tutumu kecmisdir!Yuku azaldin");
            else
                Console.WriteLine($"Result:{CurrentLoad+weight}");
        }
        public override double CalculateFuelCost(double distance)
        {
            return(distance/100)*(25+CurrentLoad*2)*1.8;
        }

        public override string GetVehicleInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate Number: {PlateNumber}, Fuel Level: {FuelLevel}% Max Speed: {MaxSpeed}";
        }

        public override void ShowBasicInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }

        
    }
}
