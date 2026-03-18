using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Motorcycle:Vehicle   
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public string Type { get; set; }


        public Motorcycle()
        {
            
        }
        public Motorcycle(int enginecapacity):this()
        {
            EngineCapacity = enginecapacity;
        }
        public Motorcycle(int enginecapacity,bool hassidecar):this(enginecapacity)
        {
            HasSidecar = hassidecar;
        }
        public Motorcycle(int enginecapacity, bool hassidecar, string type) : this(enginecapacity, hassidecar)
        {
            Type = type;
        }

        public Motorcycle(string brand) : base(brand)
        {

        }
        public Motorcycle(string brand, string model) : base(brand, model)
        {

        }
        public Motorcycle(string brand, string model, int year) : base(brand, model, year)
        {

        }
        public Motorcycle(string brand, string model, int year, string platenumber) : base(brand, model, year, platenumber)
        {

        }
        public Motorcycle(string brand, string model, int year, string platenumber, double fuelLevel) : base(brand, model, year, platenumber, fuelLevel)
        {

        }
        public Motorcycle(string brand, string model, int year, string platenumber, double fuelLevel, int maxspeed) : base(brand, model, year, platenumber, fuelLevel, maxspeed)
        {

        }
        public override double CalculateFuelCost(double distance)
        {
            return(distance/100)*4*1.5;
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
