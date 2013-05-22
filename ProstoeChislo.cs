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