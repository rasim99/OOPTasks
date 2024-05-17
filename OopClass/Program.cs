using System;

namespace OopClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat=new Cat("Mestan",1,"kedi","black");
            Dog dog=new Dog("Haciko",2,"kopek","ag-qara");
            Console.WriteLine(cat.MakeSound());
            Console.WriteLine(dog.MakeSound());
        }
    }
}
