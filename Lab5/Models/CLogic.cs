using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class CLogic
    {
        public static int ReverseNumber(int number)
        {
            int reversed = number % 10;
            number /= 10;
            while (number != 0)
            {
                reversed *= 10;
                reversed += number % 10;
                number /= 10;
            }
            return reversed;
        }
    }
}
