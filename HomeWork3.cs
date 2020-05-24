using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            CountsChar(text);

            //b) Ask user to enter the number of month.Read the value and write the amount of days in this month.
            Console.WriteLine("Input number of month:");
            byte month = Convert.ToByte(Console.ReadLine());
            
            if (month == 2)
            {
                Console.WriteLine("This month have 29 days.");
            }
            else
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    Console.WriteLine("This month have 31 days.");
                    
                }
                else
                {

                    Console.WriteLine("This month have 30 days.");
                }

            }
            // c) Input 10 integer numbers.Calculate the sum of first 5 elements if they are positive or product of last 5 element in the other case.
            Console.WriteLine("Input 10 int numbers:");
            int[] arr = new int[10];
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i]<0)
                {
                    k++;
                }
                
            }

            if (k>0)
            {
               
                 int Mult = arr[5] * arr[6] * arr[7] * arr[8] * arr[9];
                 Console.WriteLine($"Product of last 5 elements is : {Mult}"); 
            }
            else
            {
                int Sum = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
                Console.WriteLine($"Sum of first 5 elements is : {Sum}");
            }

            Console.ReadLine();

        }

        //Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text.
        public static void CountsChar(string text1)
        {
            int k1 = 0;
            int k2 = 0;
            int k3 = 0;
            int k4 = 0;
            char[] textCharArray = text1.ToCharArray();
            foreach (var ch in textCharArray)
            {
                if (ch.ToString() == "a")
                {
                    k1 = k1 + 1;
                }

                if (ch.ToString() == "o")
                {
                    k2 = k2 + 1;
                }

                if (ch.ToString() == "i")
                {
                    k3 = k3 + 1;
                }

                if (ch.ToString() == "e")
                {
                    k4 = k4 + 1;
                }
            }

            Console.WriteLine($"Text contains 'a' - {k1} time(s)! \n" + $"Text contains 'o' - {k2} time(s)!\n" +
                              $"Text contains 'i' - {k3} time(s)!\n" + $"Text contains 'e' - {k4} time(s)!\n");
        }
    }
}