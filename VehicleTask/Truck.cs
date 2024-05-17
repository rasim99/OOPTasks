using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace VehicleTask
{
    internal class Truck :Vehicle
    {
        public Truck(string make, string model, string color, int maxSpeed,
            string banType, double engineCapacity, int fuelCapacity,int loadCapasity) :
             base(make, model, color, maxSpeed, banType, engineCapacity, fuelCapacity)
        {
            LoadCapasity = loadCapasity;
        }

        public int LoadCapasity { get; set; }
        

        public override void GetDetails()
        {
            Console.WriteLine($"Make :{Make} " +
                $" Model  :  {Model}  Color  : " +
                $"{Color}  MaxSpeed  :  {MaxSpeed} km/h" +
                $" Bantype  : {BanType}   EngineCapacity  : {EngineCapacity}L " +
                $"\r\n fuelCapacity  : {FuelCapacity}Litres   LoadCapasity : {LoadCapasity} KG ");
        }
    }
}
