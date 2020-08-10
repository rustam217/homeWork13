using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork13
{
    class Farm
    {
        public string FarmName { get;  set; }
        public string Address { get; private set; }

        private List<Horse> Horses = new List<Horse>();
        private List<Sheep> SheepFlock = new List<Sheep>();
        private List<Cow> Cows = new List<Cow>();

        public Farm(string name, string address)
        {
            FarmName = name;
            Address = address;
        }

        public void AddHorse(Animal Horse) => Horses.Add((Horse)Horse);


        public void AddCow(Animal Cow) => Cows.Add((Cow)Cow);

        public void AddSheep(Animal Sheep) => SheepFlock.Add((Sheep)Sheep);


        public void FullInfo()
        {
            Console.WriteLine($"\nFarm's Name: {FarmName}  \nAddress: {Address}");
            Console.WriteLine("\nHorses:");
            foreach (var horse in Horses)
            {
                Console.WriteLine($"\t{ horse.Name}");
            }
            Console.WriteLine("Cows:");
            foreach (var cow in Cows)
            {
                Console.WriteLine($"\t{ cow.Name}");
            }
            Console.WriteLine("Sheeps:");
            foreach (var sheep in SheepFlock)
            {
                Console.WriteLine($"\t{ sheep.Name}");
            }
        }
    }
}
