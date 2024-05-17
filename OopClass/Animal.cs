using System;
using System.Collections.Generic;
using System.Text;

namespace OopClass
{
    public abstract class Animal
    {
      

        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Animal(string name, int age, string breed, string color)
        {
            Name = name;
            Age = age;
            Breed = breed;
            Color = color;
        }

        public abstract string MakeSound();
        

    }
}
