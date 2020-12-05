using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    public static class A1Logic
    {

        static int DECIMAL_NOTATION_BASE = 10;
        public static int CountDigits(int num)
        {
            int counter = 0;
            while (num > 0)
            {
                num /= DECIMAL_NOTATION_BASE;
                counter++;
            }
            return counter;
        }
    }
}
