using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDelegetes
{
    public delegate void MyDel(int m);

    public class Student
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public event MyDel MyDeland;

        public Student()
        {
        }

        public Student(string name, List<int> marks)
        {
            Name = name;
            Marks = marks;
        }

        public void AddMark(int mark)
        {
            Marks.Add(mark);
            MyDeland?.Invoke(mark);
        }
    }

    public class Parent

    {
        public Student student;

        public Parent()
        {
        }

        public Parent(Student s1)
        {
            student = s1;
        }

        public void OnMarkChange(int m)
        {
            Console.WriteLine($"In List of marks {student.Name}  add a new mark {m}!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mike", new List<int> {4, 5, 5, 4, 3, 4, 5});
            Parent Dad = new Parent(s1);
            s1.MyDeland += Dad.OnMarkChange;
            s1.AddMark(4);
            s1.AddMark(5);
            s1.AddMark(2);
            foreach (var mark in s1.Marks)
            {
                Console.WriteLine($"Marks: {mark}");
            }

            Console.ReadLine();
        }
    }
}