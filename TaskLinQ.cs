using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>{1,-5,4,3,-8,34,-15,23,9,10};
            var positive = from n in list where n > 0 select n;
            foreach (var l in positive)
            {
                Console.WriteLine(l);
            }

            var negative = from n in list where n < 0 select n;
            foreach (var l in negative)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine($"Max= {list.Max()}");
            Console.WriteLine($"Min={list.Min()}");
            Console.WriteLine($"Sum all elements= {list.Sum()}");

            var av = from a in list where a < list.Average()
                                      select a;
            
            Console.WriteLine($"First element {av.Max()} when average={list.Average()}");
            var newlist = from i in list orderby i descending select i;
            Console.WriteLine("Sorted collection:");
            foreach (var n in newlist)
            {
              Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
