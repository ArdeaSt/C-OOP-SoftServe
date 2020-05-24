using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HomeWork4
{
    public class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
        }

        public Person(string pname, DateTime year)
        {
            name = pname;
            birthYear = year;
        }

        public int Age()
        {
            int a = this.BirthYear.Year;
            int m = DateTime.Today.Year;
            int age = m - a;
            Console.WriteLine($"{Name} is {age} years old.");
            return age;
        }

        public void Input()
        {
            Console.WriteLine("Input Name of person: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Input year of birth : ");
            this.birthYear = DateTime.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            var years = BirthYear.Year;
            return String.Format($"{Name} was born in {years}");
        }

        public void ChangeName(string newname)
        {
            name = newname;
        }

        public static bool operator ==(Person A, Person B)
        {
            return (A.Name == B.Name);
        }

        public static bool operator !=(Person A, Person B)
        {
            return !(A.Name == B.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            A.Input();

            Person B = new Person();
            B.Input();

            Person C = new Person();
            C.Input();

            Person D = new Person();
            D.Input();

            Person E = new Person();
            E.Input();

            Person F = new Person();
            F.Input();

            List<Person> list = new List<Person>();
            list.Add(A);
            list.Add(B);
            list.Add(C);
            list.Add(D);
            list.Add(E);
            list.Add(F);

            foreach (var l in list)
            {
                l.Output();
                if (l.Age() < 16)
                {
                    l.ChangeName("Very Young");
                }
            }

            Console.WriteLine("*************************************");
            foreach (var m in list)
            {
                m.Output();
            }

            Console.ReadLine();
        }
    }
}