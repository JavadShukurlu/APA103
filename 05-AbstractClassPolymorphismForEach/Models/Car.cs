using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Car:Vehicle  
    {
        public int DoorCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        

        public Car()
        {
            
        }
        public Car(int doorcount):this()
        {
            DoorCount = doorcount;
        }
        public Car(int doorcount,int trunkcapasity):this(doorcount)
        {
            TrunkCapacity = trunkcapasity;
        }
        public Car(int doorcount,int trunkcapasity,bool isautomatic):this(doorcount,trunkcapasity)
        {
            IsAutomatic = isautomatic;
        }
        public Car(int doorcount,int trunkcapasity,bool isautomatic,int maxspeed):this(doorcount,trunkcapasity,isautomatic)
        {
            MaxSpeed = maxspeed;
        }
        public Car(string brand):base(brand) 
        {
            
        }
        public Car(string brand,string model):base(brand,model) 
        {
            
        }
        public Car(string brand,string model,int year):base(brand,model,year) 
        {
            
        }
        public Car(string brand,string model,int year,string platenumber):base(brand,model,year,platenumber)
        {
            
        }
        public Car(string brand,string model,int year,string platenumber,double fuelLevel):base(brand,model,year,platenumber,fuelLevel)
        {
            
        }
        public Car(string brand, string model, int year, string platenumber, double fuelLevel,int maxspeed) : base(brand, model, year, platenumber, fuelLevel,maxspeed)
        {

        }


        public override double CalculateFuelCost(double distance)
        {
            return(distance/100)*8*1.5;
        }

        public override string GetVehicleInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate Number: {PlateNumber}, Fuel Level: {FuelLevel}%";
        }

        public override void ShowBasicInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }
}
