using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask
{
    internal abstract class Vehicle
    {
        public Vehicle(string make, string model, string color, int maxSpeed, string banType,double engineCapacity,int fuelCapacity)
        {
            Make = make;
            Model = model;
            Color = color;
            MaxSpeed = maxSpeed;
            BanType = banType;
            EngineCapacity = engineCapacity;
            FuelCapacity = fuelCapacity;
        }

        public double EngineCapacity { get; set; }
        public int FuelCapacity { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        public string BanType { get; set; }

        public abstract void GetDetails();
        
    }
}
