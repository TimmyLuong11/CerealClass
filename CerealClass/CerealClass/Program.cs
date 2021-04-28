using System;
using System.IO;

namespace CerealClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            string[] lines = File.ReadAllLines("Cereal_Data.txt");

            //Looping to find the cereal with cups greater than or equal 1
            Console.WriteLine("Cereal with Calories with cups greater than or equal to 1:\n");
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split("|");
                double cup = Convert.ToDouble(pieces[3]);
                if (cup >= 1 )
                {
                    Cereal c = new Cereal()
                    {
                        Name = pieces[0],
                        Manufacturer = pieces[1],
                        Calories = Convert.ToDouble(pieces[2]),
                        Cups = Convert.ToDouble(pieces[3]),
                    };
                    Console.WriteLine($"{c.Name} is made by {c.Manufacturer} with servings size of {c.Cups} with {c.Calories} calories.");
                }
            }

            //Loop to find the cereal with calories less then or equal to 100
            Console.WriteLine("\nCereal with calories less than or equal to 100:\n");
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split("|");
                double calories = Convert.ToDouble(pieces[2]);
                if (calories <= 100)
                {
                    Cereal c = new Cereal()
                    {
                        Name = pieces[0],
                        Manufacturer = pieces[1],
                        Calories = Convert.ToDouble(pieces[2]),
                        Cups = Convert.ToDouble(pieces[3]),
                    };
                    Console.WriteLine($"{c.Name} is made by {c.Manufacturer} with {c.Calories} calories and a servings size of {c.Cups}.");
                }
            }
        }
    }
}
