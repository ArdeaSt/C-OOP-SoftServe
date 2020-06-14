using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

        public double Perimetr()
        {
            double AB = this.p1.Vidstan(p2);
            double BC = this.p2.Vidstan(p3);
            double AC = this.p1.Vidstan(p3);

            return AB + AC + BC;
        }

        public double Square()
        {
            double Piv = this.Perimetr() / 2;
            double S = Math.Sqrt(Piv * (Piv - this.p1.Vidstan(p2)) * (Piv - this.p1.Vidstan(p3)) *
                                        (Piv = this.p2.Vidstan(p3)));
            return S;
        }

        public void Print()
        {
            Console.WriteLine($"Triangle with vertex1 ({p1.X},{p1.Y})\t vertex2 ({p2.X},{p2.Y})\t vertex ({p3.X},{p3.Y})\t has perimetr {this.Perimetr():F}\n and square {this.Square():F}");
        }
            

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1, p2, p3;
            p1= new Point(1,5);
            p2=new Point(4,1);
            p3=new Point(1,1);
          Point  p4 =new Point(12,5);
            Point p5 = new Point(4,7);
            Triangle t1=new Triangle(p1,p2,p3);
            Triangle t2 =new Triangle(p4,p2,p5);
            Triangle t3=new Triangle(p1,p3,p5);
            List<Triangle> lisTriangles = new List<Triangle>{t1,t2,t3};
            foreach (var triangle in lisTriangles)
            {
               triangle.Print();
            }
            Console.ReadLine();
        }
    }
}
