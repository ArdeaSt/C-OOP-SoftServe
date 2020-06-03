using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAnonymousMetod
{
    public delegate string Reverse(string text);

    public delegate int MissingNum(int[] num);

    class Program
    {
        static void Main(string[] args)
        {
            // Create an anonymous method that takes a string as its argument and returns the string in reversed order.

            Reverse reverse = delegate(string text)
            {
                char[] temp = text.ToCharArray();
                Array.Reverse(temp);
                return new string(temp);
            };

            Console.WriteLine(reverse("Hello word"));
            Console.WriteLine(reverse("The quick brown fox"));

            // . Create a function an anonymous method that takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.
            MissingNum missingNum = delegate(int[] num)
            {
                Array.Sort(num);
                int miss = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] != i + 1)
                    {
                        miss = i + 1;
                        break;
                    }
                }
                return miss;
            };

          int print=  missingNum(new[] {1, 2, 3, 4, 6, 7, 8, 9, 10});
            Console.WriteLine($"Missing number is {print} ");

            print = missingNum(new[] {10, 5, 1, 2, 4, 6, 8, 3, 9});
            Console.WriteLine($"Missing number is {print} ");


            Console.ReadLine();
        }
    }
}