using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            this.length = l;
            this.width = w;
        }

        public void Area()
        {
            if (length == 0 || width == 0)
            {
                Console.WriteLine("Invalid length/width");
            }
            double area = length * width;
            Console.WriteLine("Area: {0}", area);
        }

        public void Perimeter()
        {
            if (length == 0 || width == 0)
            {
                Console.WriteLine("Invalid length/width");
            }
            double perimeter = 2 * length + 2 * width;
            Console.WriteLine("Perimeter: {0}", perimeter);
        }

        public double GetArea()
        {
            return length * width;
        }

        public double GetPerimeter()
        {
            return 2 * length + 2 * width;
        }

        /*
         * This is the next part of the question
         * to create a copy of a rectangle
         * 

                public Rectangle(Rectangle r)
                {
                    this.length = r.length;
                    this.width = r.width;
                }

                public void Copy(Rectangle r)
                {
                    this.length = r.length;
                    this.width = r.width;
                }

        */

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
                        Console.WriteLine("Rectangle 1 perimeter is larger by: {0}", diff);
                    }
                    else if (diff2 < 0)
                    {
                        Console.WriteLine("Rectangle 2 perimeter is larger by: {0}", diff);
                    }
                    else
                    {
                        Console.WriteLine("They have the same perimeter");
                    }

                    if (diff > 0)
                    {
                        Console.WriteLine("Rectangle 1 area is larger by: {0}", diff);
                    }
                    else if (diff < 0)
                    {
                        Console.WriteLine("Rectangle 2 area is larger by: {0}", diff);
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
                        Console.WriteLine("Rectangle perimeter is larger by: {0}", diff);
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
                        Console.WriteLine("Rectangle area is larger by: {0}", diff);
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
                        Console.WriteLine("Rectangle perimeter is larger by: {0}", diff);
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
                        Console.WriteLine("Rectangle area is larger by: {0}", diff);
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
