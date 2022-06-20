using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string> { "The Sims", "Halo", "Call Of Duty",
            "MarioKart", "Assassin's Creed", "Animal Crossing"};

            var sorted = gameNames.OrderBy(x => x.Length);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item}");
            }
            

        }
    }
}

