using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ************************************************
// Author : Nanam Vaishnavi
// Purpose : Abstract class
//*************************************************

namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    // *******************************************
    // Author : Nanam Vaishnavi
    // Purpose : Abstarct class Example 
    // *******************************************

    namespace Abstraction
    {
        abstract class Shape
        {
            public abstract double Area();
        }

        class Square : Shape
        {
            private double side = 0;
            public Square(double s)
            {
                side = s;
            }
            public override double Area()
            {
                return (side * side);
            }
        }

        class Circle : Shape
        {
            private double radius;
            public Circle(double r)
            {
                radius = r;
            }
            public override double Area()
            {
                return 3.14 * radius * radius;
            }

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Square s = new Square(8);
                Console.WriteLine(s.Area());

                Circle c = new Circle(6.5);
                Console.WriteLine(c.Area());



                Console.ReadLine();
            }
        }
    }

}
