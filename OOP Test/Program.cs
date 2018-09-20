using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountInstance c1 = new CountInstance();
            //CountInstance c2 = new CountInstance();

            //CountInstance.NumberOfInstances();

            //Circle c1 = new Circle(5);
            //Circle c2 = new Circle(2.5);
            //Circle c3 = new Circle(5);
            //c2.Area();
            //c2.Perimeter();
            //Console.WriteLine(c1.Equals(c2));
            //Console.WriteLine(c1.Equals(c3));

            //AnalyseLog a = new AnalyseLog(7);
            //a.Process();

            //Printer p = new Printer();
            //DateTime date = DateTime.Now;
            //p.print(date);

            Rectangle r1 = new Rectangle(5, 4);
            Circle c1 = new Circle(2.5);
            r1.CompareArea(c1);

            Console.ReadLine();
        }
    }
}
