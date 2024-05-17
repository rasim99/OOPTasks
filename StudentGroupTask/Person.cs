using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGroupTask
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        protected Person(string name,string surName)
        {
             Name = name;
            SurName = surName;
        }
    }
}
