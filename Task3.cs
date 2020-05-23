using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input a and b are two integers. Calculate how many integers in the range [a..b] are divided by 3 without remainder.
            Console.WriteLine("Input integer a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input integer b: ");
            int b = Int32.Parse(Console.ReadLine());
            int k = 0;
            for (int i = b; i >= a; i--)
            {
                if (i % 3 == 0)
                {
                    k = k + 1;
                }
            }

            // Input a character string. Print each second character
            Console.WriteLine($"In the range[{a}...{b}]  {k} integers are divided by 3 without remainder. ");

            Console.WriteLine("Input charecter string:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                }
                else
                {
                    Console.WriteLine(words[i]);
                }
            }

            // Input the name of the drink(coffee, tea, juice, water). Print the name of the drink and its price.
            Console.WriteLine("Input the name of drink (coffee,tea,juice,water): ");
            string drink = Console.ReadLine();
            switch (drink)
            {
                case "coffee":
                {
                    Console.WriteLine($"You choose coffee. It cost 1$.");
                    break;
                }
                case "tea":
                {
                    Console.WriteLine($"You choose tea. It cost 0.8 $.");
                    break;
                }
                case "juice":
                {
                    Console.WriteLine($"You choose juice. It cost 2$.");
                    break;
                }
                case "water":
                {
                    Console.WriteLine($"You choose water. It cost 0.5 $.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Sorry, we haven't this drink, good luck!");
                    break;
                }
            }
            // Input a sequence of positive integers(to the first negative). Calculate the arithmetic average of the entered numbers.

            Console.WriteLine("Input a sequence of positive integers:");
            int average = 0;
            int Sum = 0;
            for (int i = 1; i < 100; i++)
            {
                int[] digits = new int[100];
                digits[i - 1] = Convert.ToInt32(Console.ReadLine());
                if (digits[i - 1] < 0)
                {
                    break;
                }

                Sum = Sum + digits[i - 1];
                average = Sum / i;
            }

            Console.WriteLine($"Average Sum of entered number is {average} ");

            // Check whether the entered year is a leap.
            Console.WriteLine("Input the year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine($" {year} is leap!");
            }
            else
            {
                Console.WriteLine($"{year} isn't leap!");
            }

            // Find the sum of digits of the entered integer number
            Console.WriteLine("Input integer number");
            int number = Convert.ToInt32(Console.ReadLine());
            int dig = 0;
            int sumdigit = 0;
            int odd = 0;
            while (number > 10)
            {
                dig = number % 10;
                number = number / 10;
                sumdigit = sumdigit + dig;
                if (dig % 2 == 0)
                {
                    odd = odd + 1;
                }
            }

            sumdigit = sumdigit + number;

            Console.WriteLine($"Sum of digit = {sumdigit}");

            // Check whether the entered integer number contains only odd numbers

            if (odd > 0)
            {
                Console.WriteLine("Entered integer number contains NOT only odd numbers.");
            }
            else
            {
                Console.WriteLine("Entered integer number contains only odd numbers!");
            }

            Console.ReadLine();
        }
    }
}