using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test
{
    public class Circle
    {
        private double radius;
        private double pi = 3.14159;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return pi * radius * radius;
        }

        public double GetPerimeter()
        {
            return 2 * pi * radius;
        }

        public void Area()
        {
            double area = pi * radius * radius;
            Console.WriteLine("Area: {0}", area);
        }

        public void Perimeter()
        {
            double perimeter = 2 * pi * radius;
            Console.WriteLine("Perimeter: {0}", perimeter);
        }

        public bool Equals(Circle c)
        {
            if(this.radius == c.radius)
            {
                return true;
            }

            return false;
        }

        /*
 * Code to compare area and perimeter
 * 
 * 
 * 
        public void Compare(Rectangle r)
        {
            double area1, area2;
            double diff;
            area1 = this.GetArea();
            area2 = r.GetArea();
            double perimeter1, perimeter2;
            double diff2;
            perimeter1 = this.GetPerimeter();
            perimeter2 = r.GetPerimeter();

            diff = area1 - area2;
            diff2 = perimeter1 - perimeter2;

            if (diff2 > 0)
            {
                Console.WriteLine("Circle perimeter is larger by: {0}", diff);
            }
            else if (diff2 < 0)
            {
                Console.WriteLine("Rectangle perimeter is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same perimeter");
            }

            if (diff > 0)
            {
                Console.WriteLine("Circle area is larger by: {0}", diff);
            }
            else if (diff < 0)
            {
                Console.WriteLine("Rectangle area is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same area");
            }
        }

        public void Compare(Circle c)
        {
            double area1, area2;
            double diff;
            area1 = this.GetArea();
            area2 = c.GetArea();
            double perimeter1, perimeter2;
            double diff2;
            perimeter1 = this.GetPerimeter();
            perimeter2 = c.GetPerimeter();

            diff = area1 - area2;
            diff2 = perimeter1 - perimeter2;

            if (diff2 > 0)
            {
                Console.WriteLine("Circle 1 perimeter is larger by: {0}", diff);
            }
            else if (diff2 < 0)
            {
                Console.WriteLine("Circle 2 perimeter is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same perimeter");
            }

            if(diff > 0)
            {
                Console.WriteLine("Circle 1 area is larger by: {0}", diff);
            }
            else if (diff < 0)
            {
                Console.WriteLine("Circle 2 area is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same area");
            }
        }

        public void Compare(Square s)
        {
            double area1, area2;
            double diff;
            area1 = this.GetArea();
            area2 = s.GetArea();
            double perimeter1, perimeter2;
            double diff2;
            perimeter1 = this.GetPerimeter();
            perimeter2 = s.GetPerimeter();

            diff = area1 - area2;
            diff = perimeter1 - perimeter2;

            if (diff2 > 0)
            {
                Console.WriteLine("Circle perimeter is larger by: {0}", diff);
            }
            else if (diff2 < 0)
            {
                Console.WriteLine("Square perimeter is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same perimeter");
            }

            if (diff > 0)
            {
                Console.WriteLine("Circle area is larger by: {0}", diff);
            }
            else if (diff < 0)
            {
                Console.WriteLine("Square area is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same area");
            }
        }



        */
    }
}
