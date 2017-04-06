using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\princ\Documents\Notes\CodeEval_ComparePoints.txt"))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                                        
                    string[] coordinates = line.Split();
                    Console.WriteLine(coordinates[0]);


                }
            Console.ReadKey();
            
        }
    }
}
