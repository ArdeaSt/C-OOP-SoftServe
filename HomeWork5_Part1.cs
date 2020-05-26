using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    interface IDeveloper
    {
        String Tool { get; set; }

        void Create();
        void Destroy();
    }

    class Programmer : IDeveloper, IComparable
    {
        private string language;

        public string Tool
        {
            get { return language; }
            set { value = language; }
        }

        public Programmer()
        {
        }

        public Programmer(string tool)
        {
            language = tool;
        }

        public void Create()
        {
            Console.WriteLine($"App was created by {Tool} programmer.");
        }

        public void Destroy()
        {
            Console.WriteLine($"App was deleted from computer by {Tool} programmer!");
        }

        public int CompareTo(object obj)
        {
            IDeveloper temp = obj as IDeveloper;
            if (temp != null)
            {
                return this.Tool.CompareTo(temp.Tool);
            }
            else
            {
                throw new ArgumentException("Parameter is not Programmer");
            }
        }
    }

    class Builder : IDeveloper, IComparable
    {
        private string tool;

        public Builder()
        {
        }

        public Builder(string material)
        {
            tool = material;
        }

        public void Create()
        {
            Console.WriteLine($"House was built from {Tool} by builder!");
        }

        public void Destroy()
        {
            Console.WriteLine($"House from {Tool} destroyed  by builder!");
        }

        public string Tool
        {
            get { return tool; }
            set { value = tool; }
        }

        public int CompareTo(object obj)
        {
            IDeveloper temp = obj as IDeveloper;
            if (temp != null)
            {
                return this.Tool.CompareTo(temp.Tool);
            }
            else
            {
                throw new ArgumentException("Parameter is not Builder");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDeveloper[] developers = new IDeveloper[4];
            developers[0] = new Builder("Panel");
            developers[1] = new Programmer("C#");
            developers[2] = new Programmer("Java");
            developers[3] = new Builder("Brick");
            for (int i = 0; i < developers.Length; i++)
            {
                developers[i].Create();
            }

            for (int i = 0; i < developers.Length; i++)
            {
                developers[i].Destroy();
            }


            Console.WriteLine($"App built on the language:  {developers[2].Tool}");

            Console.WriteLine($"House was built from:  {developers[3].Tool}");

            for (int i = 0; i < developers.Length; i++)
            {
                Console.WriteLine(developers[i].Tool);
            }

            Array.Sort(developers);
            Console.WriteLine("******Sorted array **********");
            for (int i = 0; i < developers.Length; i++)
            {
                Console.WriteLine(developers[i].Tool);
            }

            Console.Read();
        }
    }
}