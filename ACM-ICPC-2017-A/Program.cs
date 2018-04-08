using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_ICPC_2017_A
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double DistanceFrom(Point Target) => Math.Sqrt(Math.Pow(X - Target.X, 2) + Math.Pow(Y - Target.Y, 2));
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            QuestionA();
            
        }
        

        static void QuestionA()
        {
            FileManager manager = new FileManager();
            var Files = manager.GetFileInFolder("A");
            foreach (var file in Files)
            {
                var StopWatch = new Stopwatch();
                StopWatch.Start();
                var contents = manager.GetContentFromFile(file);
                int NumberOfLine = Int16.Parse(contents[0]);
                double MaxDistance = 0;
                for (int i = 1; i <= NumberOfLine; i++)
                {
                    var BeginPoint = contents[i].Split(' ');
                    Point Beginning = new Point()
                    {
                        X = Int16.Parse(BeginPoint[0]),
                        Y = Int16.Parse(BeginPoint[1])
                    };
                    for (int j = 1; j < i; j++)
                    {
                        var Endpoint = contents[j].Split(' ');
                        Point Ending = new Point()
                        {
                            X = Int16.Parse(Endpoint[0]),
                            Y = Int16.Parse(Endpoint[1])
                        };
                        double Distance = Ending.DistanceFrom(Beginning);
                        if (Distance > MaxDistance) MaxDistance = Distance;
                    }
                }
                Console.WriteLine($"Distance for {file} is {MaxDistance}");
                StopWatch.Stop();
                Console.WriteLine($"Elapsed Time {StopWatch.ElapsedMilliseconds}");
            }
        }
        static void QuestionB()
        {

        }
    }
}
