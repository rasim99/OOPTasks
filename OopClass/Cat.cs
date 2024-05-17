using System;
using System.Collections.Generic;
using System.Text;

namespace OopClass
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string breed, string color) : base(name, age, breed, color)
        {
          
        }

        public override string MakeSound()
        {
            return "Miaaaaaaaaaauuuuuuuuuuuuuuuuu";
        }
    }
}
