using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Test
{
    class AnalyseLog
    {
        private int NumberOfFiles;
        private int NumberOfDelays;
        private int MaximumDelay;
        public AnalyseLog(int num)
        {
            this.NumberOfFiles = num;
            NumberOfDelays = 0;
            MaximumDelay = 0;
        }

        public void Process()
        {
            string name;
            string path;

            for(int i=1;i<=NumberOfFiles;i++)
            {
                NumberOfDelays = 0;
                MaximumDelay = 0;
                name = "spindle.log." + i;
                Console.WriteLine("File Name: {0}",name);
                Console.WriteLine();
                name = @"C:\Users\Reverside\Documents\Test\OOP Test\log\" + name;
                ReadFile(name);
                Summary();
            }
        }

        private void ReadFile(string filename)
        {
            DateTime time;
            string line;
            double difference;
            int linenumber = 1;

            StreamReader stream = new StreamReader(filename);
            line = stream.ReadLine();
            DateTime previoustime = DateTime.Parse(line.Substring(11, 8));


            while((line = stream.ReadLine()) != null)
            {
                linenumber++;
                time = DateTime.Parse(line.Substring(11, 8));
                //DateTime time = DateTime.Parse(line.Substring(11, 8));
                //difference = time.Second - previoustime.Second;
                difference = time.Subtract(previoustime).TotalSeconds;

                if(difference > 5)
                {
                    if(difference > MaximumDelay)
                    {
                        MaximumDelay = Convert.ToInt32(difference);
                    }

                    NumberOfDelays ++;

                    Console.WriteLine("Line:{0} - {1}sec - {2}",linenumber,difference,line);
                }

                previoustime = time;
            }
        }

        private void Summary()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Summary: {0} delays, Maximum: {1} sec", NumberOfDelays, MaximumDelay);
            Console.WriteLine();
        }
    }
}
