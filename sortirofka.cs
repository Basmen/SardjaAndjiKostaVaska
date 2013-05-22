using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void kostya(int[] m)
        {
            int i, j, x;
            for (i = 0; i < m.Length; i++)
            {
                for (j = 0; j < m.Length; j++)
                {
                    if (m[i] < m[j])
                    {
                        x = m[i];
                        m[i] = m[j];
                        m[j] = x;
                    }
                }
            }
            for (i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] m = { 2, 67, 234, 7, 1, 4, 78, 345, 567, 12, 7 };
            kostya(m);
        }
        
    }
}
