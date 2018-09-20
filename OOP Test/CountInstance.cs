using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test
{
    class CountInstance
    {
        private static int count = 0;

        public CountInstance()
        {
            count++;
        }
        ~CountInstance()
        {
            count--;
        }

        static public void NumberOfInstances()
        {
            Console.WriteLine("There are currently {0} instances of the class", count);
        }
    }
}
