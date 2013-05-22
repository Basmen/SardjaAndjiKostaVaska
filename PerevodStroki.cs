static string PerevodStroki(string s) 
        {
            string r = null;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];
            }
            return r;
        }