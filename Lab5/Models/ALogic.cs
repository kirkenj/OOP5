using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class ALogic
    {
        public static int GetSymOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
