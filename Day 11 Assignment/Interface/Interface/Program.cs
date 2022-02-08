using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// **************************************************************************
// Author : Nanam Vaishnavi
// Purpose : class IShape  including Square, Circle,Rectangle,Triangle
// ***************************************************************************

namespace Interface
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }
    class Square : IShape
    {
        private int side;
        public void ReadSide()
        {
            Console.WriteLine(" Enter  side: ");
            side = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculatePerimeter()
        {
            return 4 * side;
        }

        public int CalculateArea()
        {
            return side * side;
        }

    }
    class Circle : IShape
    {
        private int radius;

        public void ReadRadius()
        {
            Console.WriteLine(" Enter Radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculatePerimeter()
        {
            return 22 * radius * radius / 7;
        }
        public int CalculateArea()
        {
            return 2 * 22 * radius / 7;
        }
    }
    class Rectangle : IShape
    {
        private int length;
        private int breadth;


        public void ReadLength()
        {
            Console.WriteLine("Enter Length:  ");
            length = Convert.ToInt32(Console.ReadLine());
        }
        public void ReadBreadth()
        {
            Console.WriteLine("Enter Breadth:  ");
            breadth = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculatePerimeter()
        {
            return 2 * (length + breadth);
        }
        public int CalculateArea()
        {
            return length * breadth;
        }
    }
    class Triangle : IShape
    {

        private int Side1;
        public void ReadSide1()
        {
            Console.WriteLine("Enter side 1");
            Side1 = Convert.ToInt32(Console.ReadLine());
        }
        private int Side2;
        public void ReadSide2()
        {
            Console.WriteLine("Enter side2");
            Side2 = Convert.ToInt32(Console.ReadLine());
        }
        private int Side3;

        public void Readside3()
        {
            Console.WriteLine("Enter side3");
            Side3 = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateArea()
        {
            float s = (Side1 + Side2 + Side3) / 2;
            int Area = (int)Math.Sqrt((s * (s - Side1) * (s - Side2) * (s - Side3)));
            return Area;
        }

        public int CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Square s = new Square();
                s.ReadSide();
                Console.WriteLine(s.CalculatePerimeter());
                Console.WriteLine(s.CalculateArea());

                Circle c = new Circle();
                c.ReadRadius();
                Console.WriteLine(c.CalculatePerimeter());
                Console.WriteLine(c.CalculateArea());

                Rectangle r = new Rectangle();
                r.ReadLength();
                r.ReadBreadth();
                Console.WriteLine(r.CalculatePerimeter());
                Console.WriteLine(r.CalculateArea());

                Triangle tr = new Triangle();
                tr.ReadSide1();
                tr.ReadSide2();
                tr.Readside3();

                Console.WriteLine(tr.CalculatePerimeter());
                Console.WriteLine(tr.CalculateArea());
                Console.ReadLine();
            }
        }
    }
}
