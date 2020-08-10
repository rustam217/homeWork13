using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork13
{
    class Horse : Animal
    {
        public override byte Age { get; set; }
        public override int Weight { get; set; }
        public Horse(string name, string gender, byte age, int weight) : base(name, gender, age, weight)
        {
            if (Age < 30 && Age > 0) Age = age;
            else Console.WriteLine("Incorrect Age! ");

            if (Weight <= 740 && Weight >= 0) Weight = weight;
            else Console.WriteLine("Incorrect Weight! ");
        }

        public override void Eat()
        {
            Console.WriteLine("Horse eating Oats !");
        }
    }
}
