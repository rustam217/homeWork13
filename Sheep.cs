using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork13
{
    class Sheep : Animal 
    {
        public override byte Age { get; set; }
        public override int Weight { get; set; }
        public Sheep(string name, string gender, byte age, byte weight) : base(name, gender, age, weight)
        {
            if (Age <= 10 && Age >= 0) Age = age;
            else Console.WriteLine("Incorrect Age! ");

            if (Weight <= 45 && Weight >= 0) Weight = weight;
            else Console.WriteLine("Incorrect Weight! ");
        }

        public override void Eat()
        {
            Console.WriteLine("Sheeps eating Hay ! ");
        }
    }
}
