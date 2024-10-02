using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic02._10._2024
{
    public delegate double DoubleDelegate(double x, double y);
    public delegate void IntDelegate(int n);
    public delegate void AnonDelegate();
    class Dispacher
    {
        public event DoubleDelegate eventDouble;
        public event IntDelegate eventInt;

        public double OnEventDouble(double x, double y)
        {
            if (eventDouble != null)
                return eventDouble(x, y);

            throw new NullReferenceException();
        }

        public void OnEventInt(int n = 0)
        {
            if (eventInt != null)
                eventInt(n);

            throw new NullReferenceException();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

    }

    internal class Program
    {
        // анонимный делегат
        /*delegate (параметры) {
            // код    
        };*/

        // лямбда выражения
        // (параметры) => {}
        static double Div(double x, double y)
        {
            if (y != 0)
                return x / y;

            throw new DivideByZeroException();
        }
        static void Main(string[] args)
        {
            /*Dispacher dispacher = new Dispacher();

            //dispacher.eventDouble += Div;
            dispacher.eventDouble += delegate (double a, double b)
            {
                if (b != 0)
                    return a / b;

                throw new DivideByZeroException();
            };

            dispacher.eventDouble += (double a, double b) =>
            {
                if (b != 0)
                    return a / b;

                throw new DivideByZeroException();
            };
            dispacher.eventInt += delegate (int n)
            {
                Console.WriteLine(n);
            };
            Console.WriteLine( dispacher.OnEventDouble(8, 4));
            dispacher.OnEventInt(45454);*/

            List<Student> list = new List<Student> {
                new Student
            {
                Name = "Ivan",

                BirthDate = DateTime.Parse("1992-12-5")

            },
            new Student
            {
                Name = "Petr",
                BirthDate = DateTime.Parse("1990-5-16")
            },
            new Student
            {
                Name = "Sergey",
                BirthDate = DateTime.Parse("1992-12-15")
            },
            new Student
            {
                Name = "Elena",
                BirthDate = DateTime.Now
            }
        };
            list.FindAll(student =>  student.BirthDate.Month == 12);

        }
    }
}
