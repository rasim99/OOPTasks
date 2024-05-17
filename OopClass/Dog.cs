using System;
using System.Collections.Generic;
using System.Text;

namespace OopClass
{
    public class Dog :Animal
    {
        public Dog(string name, int age, string breed, string color) : base(name, age, breed, color)
        {

        }

        public override string MakeSound()
        {
            return "Havvv Havvvv havvvvv";
        }
    }
}
