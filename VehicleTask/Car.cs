using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask
{
    internal class Car : Vehicle
    {
        public int PersonCount { get; set; }

        public Car( string make, string model, string color, int personCount, int maxSpeed, 
            string banType, double engineCapacity, int fuelCapacity) : 
            base(make, model, color, maxSpeed, banType, engineCapacity, fuelCapacity)
        {
               PersonCount = personCount;

        }

        

        public override void GetDetails()
        {
            //Console.WriteLine($"Make :{Make} " +
            //    $" Model  :  {Model}  Color  : " +
            //    $"{Color}  MaxSpeed  :  {MaxSpeed} " +
            //    $" Bantype  : {BanType}  PersonCount : {PersonCount}");

            Console.WriteLine($"Make :{Make} " +
               $" Model  :  {Model}  Color  : " +
               $"{Color}  MaxSpeed  :  {MaxSpeed} km/h" +
               $" Bantype  : {BanType}   EngineCapacity  : {EngineCapacity}L " +
               $" \r\nfuelCapacity  :  {FuelCapacity} Litres   PersonCount : {PersonCount}  person");
        }
    }
}
