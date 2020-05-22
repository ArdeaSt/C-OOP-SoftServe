using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    ///<summary>
    /// Identify enum TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted).  Assign status “Pass” for the variable  test1Status and print the value of the variable console.
    /// Determine RGB structure that represents the color with fields red, green, blue (type byte).
    /// Identify two variables of this type and enter their fields for white and black colors.
    /// Create Console Application project in VS.
    /// In method Main() write code for solving next task:
    ///  * read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum HTTPError)
    ///  * declare struct Dog with fields Name, Mark, Age.Declare variable myDog of Dog type and read values for it.Output myDos into console.
    /// (Declare method ToString in struct)
    ///</summary>
    struct RGB
    {
        public byte R;
        public byte G;
        public byte B;

    }

    struct Dog
    {
        public string Name;
        public string Mark;
        public byte Age;
        public override string ToString()
        {
            return String.Format($"The Dog {Name} is {Mark}. His {Age} years old. ");
        }
    }
    enum TestCaseStatus:byte
    {
        Pass=100,
        Failed,
        Blocked,
        WP,
        Unexecuted
    }

    enum HTTPError
    {
       BadRequest=400,
        Unauthorized,
        PaymentRequired,
        Forbidden,
        NotFound
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test1Status = TestCaseStatus.Pass;
            Console.WriteLine((byte)test1Status);

            RGB white;
            white.R = 255;
            white.G = 255;
            white.B = 255;

            RGB black;
            black.R = 0;
            black.G = 0;
            black.B = 0;

            Console.WriteLine("Input number of error: ");
            HTTPError CurrError;
            CurrError = (HTTPError) Enum.Parse(typeof(HTTPError), Console.ReadLine());
            switch (CurrError)
            {
                case (HTTPError)400:
                    Console.WriteLine($"This error is { HTTPError.BadRequest}");
                    break;
                case (HTTPError)401:
                    Console.WriteLine($"This error is { HTTPError.Unauthorized}");
                    break;
                case (HTTPError)402:
                    Console.WriteLine($"This error is { HTTPError.PaymentRequired}");
                    break;
                case (HTTPError)403:
                    Console.WriteLine($"This error is { HTTPError.Forbidden}");
                    break;
                case (HTTPError)404:
                    Console.WriteLine($"This error is { HTTPError.NotFound}");
                    break;
                default:
                    Console.WriteLine("This error is missing on the base. Good Luck!");
                    break;
            }


            Dog MyDog1;
            MyDog1.Age = 2;
            MyDog1.Mark = "Bulldog";
            MyDog1.Name = "Chacky";
            Console.WriteLine(MyDog1.ToString());

            Dog MyDog2;
            MyDog2.Age = 5;
            MyDog2.Mark = "German shepherd";
            MyDog2.Name = "Buck";
            Console.WriteLine(MyDog2.ToString());

            Console.ReadLine();
        }
    }
}
