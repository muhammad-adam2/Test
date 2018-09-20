using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test
{
    class Square
    {
        private double length;

        public Square(double l)
        {
            this.length = l;
        }

        public double GetArea()
        {
            return length * length;
        }

        public double GetPerimeter()
        {
            return 4 * length;
        }

        public void Area()
        {
            double area = length * length;
            Console.WriteLine("Area: {0}", area);
        }

        public void Perimeter()
        {
            double perimeter = 4 * length;
            Console.WriteLine("Perimeter: {0}", perimeter);
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
                Console.WriteLine("Square perimeter is larger by: {0}", diff);
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
                Console.WriteLine("Square area is larger by: {0}", diff);
            }
            else if (diff < 0)
            {
                Console.WriteLine("Rectangle  area is larger by: {0}", diff);
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
                Console.WriteLine("Square perimeter is larger by: {0}", diff);
            }
            else if (diff2 < 0)
            {
                Console.WriteLine("Circle perimeter is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same perimeter");
            }

            if(diff > 0)
            {
                Console.WriteLine("Square area is larger by: {0}", diff);
            }
            else if (diff < 0)
            {
                Console.WriteLine("Circle area is larger by: {0}", diff);
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
                Console.WriteLine("Square 1 perimeter is larger by: {0}", diff);
            }
            else if (diff2 < 0)
            {
                Console.WriteLine("Square 2 perimeter is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same perimeter");
            }

            if (diff > 0)
            {
                Console.WriteLine("Square 1 area is larger by: {0}", diff);
            }
            else if (diff < 0)
            {
                Console.WriteLine("Square 2 area is larger by: {0}", diff);
            }
            else
            {
                Console.WriteLine("They have the same area");
            }
        }



        */
    }
}
