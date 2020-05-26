using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> dreamteam = new Dictionary<uint, string>();
            dreamteam.Add(10, "Messi");
            dreamteam.Add(7, "Ronaldo");
            dreamteam.Add(1, "Buffon");
            dreamteam.Add(2, "Maldini");
            dreamteam.Add(3, "Ramos");
            dreamteam.Add(4, "Carlos");
            dreamteam.Add(5, "Drogba");

            Console.WriteLine("Input number of football player in DreamTeam: ");
            uint number = UInt32.Parse(Console.ReadLine());
            if (dreamteam.ContainsKey(number))
            {
                Console.WriteLine($"This player is {dreamteam[number]}");
            }


            else
            {
                Console.WriteLine($"Sorry, but player with number {number} is empty! Try again. ");
            }


            Console.ReadLine();
        }
    }
}