using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork13
{
    abstract class Animal
    {
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public abstract byte Age { get; set; }
        public abstract int Weight { get;  set; }

       public Animal(string name, string gender, byte age, int weight)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Weight = weight;
        }

        public abstract void Eat();
    }
    
}
