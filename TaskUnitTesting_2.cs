using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUnitTesting2
{
    [Serializable]
    public class Person
    {
       
        public string name;
       
        public DateTime birthYear;

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
            Person A= new Person("Selly", new DateTime(1999,12,12));
            A.ChangeName("bob");
            A.Age();
            Console.ReadLine();
        }
    }
}
