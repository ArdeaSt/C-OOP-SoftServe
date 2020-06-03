using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExtantionMethod
{
    public static class UserService
    {
        public static string Rational(this int a,int x)
        {
            decimal temp =(decimal)a / x;

            return temp.ToString("g2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            Console.WriteLine(a.Rational(7));
            Console.WriteLine(b.Rational(6));
            Console.ReadLine();
        }
    }
}
