using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    abstract class Shape: IComparable
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

    class Circle:Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius;}
            set { radius=value; }
        }

        public Circle()
        {
            
        }

        public Circle(string name, double radius): base(name)
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

    class Square:Shape
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
        public Square(string name,double side) : base(name)
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
            double S = Math.Pow(side,2);
            return S;
        }

       
    }
    class Program
    {
        public static void Input(List<Shape> shapes)
        {
            
            Console.WriteLine("Enter data for 10  shapes.");
            Circle one = new Circle();
            Circle two = new Circle();
            Circle three = new Circle();
            Circle four = new Circle();
            Circle five = new Circle();
            Console.WriteLine(" Name for circle :");
            one.Name = Console.ReadLine();
            Console.WriteLine("1. Radius of circle:");
            one.Radius = Double.Parse(Console.ReadLine());

            Console.WriteLine(" Name for circle :");
            two.Name = Console.ReadLine();
            Console.WriteLine(" Radius of circle:");
            two.Radius = Double.Parse(Console.ReadLine());

            Console.WriteLine(" Name for circle :");
            three.Name = Console.ReadLine();
            Console.WriteLine("1. Radius of circle:");
            three.Radius = Double.Parse(Console.ReadLine());

            Console.WriteLine(" Name for circle :");
            four.Name = Console.ReadLine();
            Console.WriteLine("1. Radius of circle:");
            four.Radius = Double.Parse(Console.ReadLine());

            Console.WriteLine(" Name for circle :");
            five.Name = Console.ReadLine();
            Console.WriteLine("1. Radius of circle:");
            five.Radius = Double.Parse(Console.ReadLine());

            shapes.Add(one);
            shapes.Add(two);
            shapes.Add(three);
            shapes.Add(four);
            shapes.Add(five);

            Square six = new Square();
            Square seven = new Square();
            Square eight = new Square();
            Square nine = new Square();
            Square ten = new Square();

            Console.WriteLine(" Name for square :");
            six.Name = Console.ReadLine();
            Console.WriteLine("1. Side of square:");
            six.Side = Double.Parse(Console.ReadLine());

            Console.WriteLine(" Name for square :");
            seven.Name = Console.ReadLine();
            Console.WriteLine("1. Side of square:");
            seven.Side = Double.Parse(Console.ReadLine());

            Console.WriteLine(" Name for square :");
            eight.Name = Console.ReadLine();
            Console.WriteLine("1. Side of square:");
            eight.Side = Double.Parse(Console.ReadLine());

            Console.WriteLine(" Name for square :");
            nine.Name = Console.ReadLine();
            Console.WriteLine("1. Side of square:");
            nine.Side = Double.Parse(Console.ReadLine());

            Console.WriteLine(" Name for square :");
            ten.Name = Console.ReadLine();
            Console.WriteLine("1. Side of square:");
            ten.Side = Double.Parse(Console.ReadLine());
            shapes.Add(six);
            shapes.Add(seven);
            shapes.Add(eight);
            shapes.Add(nine);
            shapes.Add(ten);

        }
        static void Main(string[] args)
        {
          List<Shape> shapes = new List<Shape>();
            Input(shapes);

            foreach (var shape in shapes)
            {

                Console.WriteLine(
                    $"Shape {shape.Name} is {shape.GetType().Name} Area= {shape.Area()}  Perimetr = {shape.Perimetr()} ");
            }

            var ShapesSortedbyPerimtr = from shape in shapes orderby shape.Perimetr() select shape;
            Console.WriteLine($"Shape with biggest perimetr is {ShapesSortedbyPerimtr.Last().Name}");

            shapes.Sort();
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape {shape.Name} is {shape.GetType().Name} Area= {shape.Area()}  Perimetr = {shape.Perimetr()} ");
            }
            Console.ReadLine();
        }
    }
}
