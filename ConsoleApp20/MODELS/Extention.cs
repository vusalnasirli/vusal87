using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20.MODELS
{
    static class Extention
    {
        public static int Power ( this int a , int b)
        {
            int result = 1;
            bool n = true;
            if (a < 0)
            {
                n = false;
                b = b * -1;
            }
            for (int i = 1; i <= b; i++)
            {
                if (n)
                    result = result * a;
                else
                    result /= a;
            }
            return result;
        }
    }
}
