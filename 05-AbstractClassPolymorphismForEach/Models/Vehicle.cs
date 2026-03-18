using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; } = 100;
        public int MaxSpeed { get; set; }



        public Vehicle()
        {
            
        }
        public Vehicle(string brand):this() 
        {
            Brand = brand;
        }
        public Vehicle(string brand,string model):this( brand)
        {
            Model = model;
        }
        public Vehicle(string brand,string model,int year):this( brand,model)
        {
            Year = year;
        }
        public Vehicle(string brand,string model,int year,string platenumber):this( brand,model,year)
        {
            PlateNumber = platenumber;
        }
        public Vehicle(string brand, string model, int year, string plateNumber, double fuelLevel) : this(brand, model, year, plateNumber)
        {
            FuelLevel = fuelLevel;
        }
        public Vehicle(string brand, string model, int year, string plateNumber, double fuelLevel,int maxspeed) : this(brand, model, year, plateNumber,fuelLevel)
        {
            MaxSpeed = maxspeed;
        }
        public abstract double CalculateFuelCost(double distance);

        public abstract string GetVehicleInfo();



        public abstract void ShowBasicInfo();
           
    }
}
