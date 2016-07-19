using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static ProjectEuler.Solutions.Solutions1_10;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            Console.WriteLine(GetSmallestMultiple());
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds / 1000);
            
        }
    }
}
