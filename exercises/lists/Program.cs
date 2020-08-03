using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> neptunePluto = new List<string>() { "Uranus", "Neptune", "Pluto" };

            planetList.AddRange(neptunePluto);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");


            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Contains(i)) {
                    Console.WriteLine($"numbers list contains {i}");
                }
                else {
                    Console.WriteLine($"numbers list does not contain {i}");
                }

            }
        }
    }
}
