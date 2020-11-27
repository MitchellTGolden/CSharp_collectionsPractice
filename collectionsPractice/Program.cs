using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            // THREE BASIC ARRAYS
            int[] numArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            bool[] boolArr = new bool[] { true, false, true, false, true, false, true, false, true, false };

            // LIST OF FLAVORS
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("SpaceCrab");
            flavors.Add("Strawberry");
            flavors.Add("Pineapple");
            Console.WriteLine($"We currently know of {flavors.Count} flavors.");
            Console.WriteLine(flavors[2]);
            flavors.Remove("SpaceCrab");
            Console.WriteLine($"We currently know of {flavors.Count} flavors.");

            // USER INFO DICTIONARY
            Dictionary<string, string> users = new Dictionary<string, string>();
            foreach (var name in names)
            {
                users.Add(name, flavors[rand.Next(0, flavors.Count)]);
            }
            foreach (var entry in users)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }






        }
    }
}
