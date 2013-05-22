using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void integral(int a, int b)
        {
            double x = 0;
            double y = 0;
            double s = 0;
            double I = 0;
            double h = 0.0000001;
            for (x = a; x <= b; x = x + h)
            {
                y = Math.Sqrt(1 - x * x);
                s = s + y;
            }
            I = h * s;
            Console.WriteLine(I);   
        }
        static void Main(string[] args)
        {
            integral(-1,1);
        }
    }
}
