using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TaskExepcion_PART2
{
    [Serializable]
    class Program
    {
        public static void ReadNumber(int start, int end)
        {
            Console.WriteLine("Input 10 numbers");
            int[] arr = new int[10];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Digit numer {i + 1}  :");
                    arr[i] = Int32.Parse(Console.ReadLine());
                }

                Array.Sort(arr);

                if (arr[0] > start & arr[9] < end)
                {
                    Console.WriteLine($"The integer numbers are in the range: {start}...{end} ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                else
                {
                    throw new Exception($"The integer numbers are out of the range {start}...{end}!!!");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            ReadNumber(1, 100);
            Console.ReadLine();
        }
    }
}