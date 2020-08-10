using System;

namespace homeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal horse1 = new Horse("Sisi", "Female", 25, 680);
            Animal horse2 = new Horse("Persival", "Male", 20, 700);

            Animal sheep1 = new Sheep("Shon", "Male", 10, 40);
            Animal sheep2 = new Sheep("Liza", "Female", 8, 37);

            Animal cow1 = new Cow("Zoe", "Female", 25, 860); //incorrect age and weight 
            Animal cow2 = new Cow("Angus", "Male", 19, 840);

            Farm farm = new Farm("Ferma", "Street #123");

            horse1.Eat();

            cow1.Eat();

            sheep1.Eat();

            while (true)
            {
                farm.FullInfo();
                Console.Write("\nЧтобы добавить животное на ферму выберите его из списка" +
                    "\nhorse1-->Sisi\thorse2-->Persival\nsheep1-->Shon\tsheep2-->Liza\ncow1-->Zoe\tcow2-->Angus\n>");

                var input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "cow1":
                        farm.AddCow(cow1); break;

                    case "cow2":
                        farm.AddCow(cow2); break;

                    case "sheep1":
                        farm.AddSheep(sheep1); break;

                    case "sheep2":
                        farm.AddSheep(sheep2); break;

                    case "horse1":
                        farm.AddHorse(horse1); break;

                    case "horse2":
                        farm.AddHorse(horse2); break;
                    default:
                        break;
                }
            }
        }
    }
}