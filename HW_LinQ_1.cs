using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexHomeWork1
{
    abstract class Shape : IComparable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Shape()
        {

        }
        public Shape(string name)
        {
            this.name = name;
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimetr()
        {
            return 0;
        }
        public int CompareTo(object obj)
        {
            Shape temp = obj as Shape;
            if (temp != null)
            {
                return temp.Area().CompareTo(this.Area());
            }
            else
            {
                throw new ArgumentException("Parametr isnot shape!");
            }
        }
    }

    class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle()
        {

        }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimetr()
        {
            return Math.PI * 2 * radius;
        }
    }

    class Square : Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square()
        {

        }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            double S = Math.Pow(side, 2);
            return S;
        }


        public override double Perimetr()
        {
            double S = Math.Pow(side, 2);
            return S;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>
            {
                new Circle("C1", 3), new Circle("C2", 5), new Circle("C3", 2), new Square("S1", 7), new Square("S2", 4),
                new Square("S3", 1)
            };


            // Find and write into the file shapes with area from range [10,100]

            var shapeArea = from shape in Shapes where shape.Perimetr() > 10 & shape.Perimetr() < 100 select shape;
            foreach (var shape in shapeArea)
            {
                string example = "C";
                string str = @"E:\shapes.txt";
                using (StreamWriter stWriter = new StreamWriter(str, true))
                {
                    stWriter.WriteLine($"Shape {shape.Name} has area {shape.Area()}");
                }
            }

            // Find and write into the file shapes which name contains letter 'a'
            var shapeName = from shape in Shapes where shape.Name.Contains("C") select shape;
            foreach (var shape in shapeName)
            {

                string str1 = @"E:\shapesNames.txt";
                using (StreamWriter strWriter = new StreamWriter(str1, true))
                {
                    strWriter.WriteLine($"Shape {shape.Name} contains 'C' ");
                }
            }
            //Find and remove from the list all shapes with perimeter less then 5. Write resulted list into Console 
            Shapes.RemoveAll(x => x.Perimetr() < 5);
            foreach (var shape in Shapes)
            {
                Console.WriteLine(shape.Name);
            }

            Console.ReadLine();

        }
    }
   
           
      

}
