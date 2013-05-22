using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemuProgrSRS
{
    class Program
    {
           static string PerevodStroki(string s)
        {
            string r = null;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];
            }
            return r;
        }
        static int ProstoeChislo(int a)
        {
            int b,k,p;
            k = 0;
            p = a;
            while (true)
            {
                p++;
                a = p;
                b=p;
                for (; a >= 1; a--)
                {
                    if (b % a == 0) k++;
                }
                if (k == 2) break;
                else k = 0;
            }
            return b;
        }
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
        static void integral(int a, int b)
        {
            double x = 0, y = 0, s = 0, I = 0, h = 0.0000001;
            for (x = a; x <= b; x = x + h)
            {
                y = Math.Sqrt(1 - x * x);
                s += y;
            }
            I = h * s;
            Console.WriteLine(I);
        }

        static void Main(string[] args)
        {
            //Программа первая: Вычисление интеграла под кривой в интервале от -1 до 1
            integral(-1, 1);
            Console.ReadLine();
            //Программа вторая: Сортировка массива
            int[] m = { 2, 67, 234, 7, 1, 4, 78, 345, 567, 12, 7 };
            kostya(m);
            Console.ReadLine();
            //Программа третья: Вывод строки задом наперед
            string s;
            s = "Hello,World!";
            Console.WriteLine(PerevodStroki(s));
            Console.ReadLine();
            //Программа четвертая: Минимальное простое число больше заданного
            int a;
            a = 8;
            Console.WriteLine(ProstoeChislo(a));
            Console.ReadLine();
        }
    }
}
