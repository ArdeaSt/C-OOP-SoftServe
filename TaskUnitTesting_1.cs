using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
   public struct Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Vidstan(Point P)
        {
           return  Math.Sqrt( Math.Pow((this.X - P.X), 2) + Math.Pow((this.Y - P.Y), 2));
        }
    }

    public class Triangle
    {
        private Point p1, p2, p3;

        public Triangle(Point a,Point b, Point c)
        {
            p1=a; p2 =b ;p3 = c;
        }
        public void Perimetr() { }
        public  void Square() { }
        public  void Print() { }
            

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1, p2, p3;
            p1= new Point(1,5);
            p2=new Point(4,1);
            p3=new Point(1,1);
            Triangle t1=new Triangle(p1,p2,p3);
            p1.Vidstan(p2);
            Console.ReadLine();
        }
    }
}
