using System;

namespace VehicleTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car=new Car("BMW","X6M","black",5,330,"Crossover",4.4,60);
            car.GetDetails();

            Truck truck = new Truck("Mercedes", "Atego", "white", 240, "Truck", 3.5,70,100);
            
            truck.GetDetails();
        }
    }
}
