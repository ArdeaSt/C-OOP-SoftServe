using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskException
{
    class Program
    {
        public static int Div(int a, int b)
        {
            return  a / b;
        }
        static void Main(string[] args)
        {
          

            try
            {
                Console.WriteLine("Input 2 integer number:");
                Console.WriteLine("Input a=");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("input b=");
                int b = Int32.Parse(Console.ReadLine());
                

                if (a <b)
                {
                    throw new ArgumentException("Error! The first integer must be biger than second integer!");
                }

                int ans = Div(a, b);
                Console.WriteLine($"a/b ={ans}");

            }

            catch (FormatException e)
            {
                Console.WriteLine("You entered wrong format! " + e.Message);
              

            }
            catch (OverflowException e)
            {
                Console.WriteLine("You entered big number!" + e.Message);
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();

        }
    }
}
