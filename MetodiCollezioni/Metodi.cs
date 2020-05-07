using System;

namespace MetodiCollezioni
{
    public class Metodi
    {
        public static bool StringheUguali(string s1, string s2)
        {
            if (s1 == s2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool ContainsDoubleChar(string s3) 
        {
            int maiuscole = 0;
            for (int i = 0; i < s3.Length; i++)
            {
                if (Char.IsUpper(s3[i]) == true)
                    maiuscole++;
            }
            if (maiuscole > 0)
                return true;
            else
                return false;
        }
    }
}
