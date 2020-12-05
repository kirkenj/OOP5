using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    public static class A1Logic
    {
        public static int CountDigits(int num)
        {
            int counter = 0;
            while (num > 0)
            {
                num /= 10;
                counter++;
            }
            return counter;
        }
    }
}
