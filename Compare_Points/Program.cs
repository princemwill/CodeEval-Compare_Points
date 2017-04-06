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
                    //Console.WriteLine(coordinates[0]);

                    //first set of coordinates "x,y" named o & p in challenge
                    int o = int.Parse(coordinates[0]);
                    int p = int.Parse(coordinates[1]);

                    //second set of coordinates "x2,y2" named q & r in challenge
                    int q = int.Parse(coordinates[2]);
                    int r = int.Parse(coordinates[3]);

                    


                    var location = new StringBuilder();
                    
                        if ((p - r == 0) && (o - q == 0))
                        {
                            location.Append("here");                           
                        }
                        else if (p - r < 0)
                        {
                            location.Append("N");
                        }
                        else if (p - r > 0)
                        {
                            location.Append("S");
                        }
                        else if (p - r == 0)
                        {
                            location.Append("");
                        }
                        else if (o - q < 0)
                        {
                            location.Append("E");
                        }
                        else if (o - q > 0)
                        {
                            location.Append("W");
                        }
                        else if (o - q == 0)
                        {
                            location.Append("");
                        }
                                               
                                        
                    Console.WriteLine(location);

                }
            Console.ReadKey();
            
        }
    }
}
