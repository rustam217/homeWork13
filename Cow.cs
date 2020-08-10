using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork13
{
    class Cow : Animal
    {
        public override byte Age { get; set; }
        public override int Weight { get; set; }
        public Cow(string name, string gender, byte age, int weight) : base(name, gender, age, weight)
        {
            if (Age < 20 && Age > 0) Age = age;
            else Console.WriteLine("Incorrect Age!");

            if (Weight <= 850 && Weight >= 0) Weight = weight;
            else Console.WriteLine("Incorrect Weight!");
        }

        public override void Eat()
        {
            Console.WriteLine("Cow eating Grass!");
        }

        
    }

}