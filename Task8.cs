using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace ConsoleApp18
{
    public class Person :IComparable
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Person name: {this.name}");
        }

        public int CompareTo(object obj)
        {
            Person temp= obj as Person;
            if (temp !=null)
            {
                return this.Name.CompareTo(temp.Name);
            }
            else
            {
                throw new ArgumentException("Parameter is not Person! ");
            }
        }
    }

    public class Stuff:Person
    {
        private int salary;
        public int Salary
        {
            get { return salary; }
        }

        public Stuff (string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"Person {Name} has salary {salary}");
        }
    }

    public class Teacher : Stuff
    {
        private string subject;
        public string Subject
        {
            get { return subject;}
            set { value = subject; }
        }


        public override void Print()
        {
            Console.WriteLine($"{Name} is teacher of {Subject}. Has salary {Salary} ");
        }

        public Teacher(string name, int salary,string subject) : base(name, salary)
        {
            this.subject = subject;
        }
    }
    public class Developer: Stuff
    {
        public int level;
        public Developer(string name, int salary, int level) : base(name, salary)
        {
            this.level = level;
        }

        public override void Print()
        {
            Console.WriteLine($"The developer {Name} has level {level}. His salary is {Salary}");
        }
      
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Teacher("Nadia", 10000,"English"));
            list.Add(new Developer("Bodia", 15000,1));
            list.Add(new Person("Vova"));
            list.Add(new Stuff("Andrew", 5000));
            foreach (var l in list)
            {
                l.Print();
            }

            Console.WriteLine("Enter person name: ");
            string tempname = Console.ReadLine();
            foreach (var l in list)
            {
                if (tempname==l.Name)
                {
                    l.Print();
                }
            }

            list.Sort();
            using (StreamWriter writer = File.CreateText("SortedList.txt"))
            {
                foreach (var l in list)
                {
                    writer.WriteLine(l.Name);
                }  
            }

            Console.WriteLine("File SortedList.txt is saved." );


            List<Stuff> employers = new List<Stuff>();
            employers.Add(new Developer("Vlad",20000,3));
            employers.Add(new Developer("Vasyl", 18000,2));
            employers.Add(new Teacher("Lian",10000,"Biology"));
            employers.Add(new Teacher("Ben",8000,"English"));

            var SortEmployers = from l in employers orderby l.Salary select l;
            foreach (var Emp in SortEmployers)
            {
                Emp.Print();
            }

            Console.ReadLine();
        }
    }
}
