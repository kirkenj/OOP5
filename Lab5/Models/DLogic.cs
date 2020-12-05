using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class DLogic
    {
        public static int FindMaxDigit(int number)
        {
            int max = number % 10;
            number /= 10;
            while (number != 0)
            {
                if (max < number % 10)
                {
                    max = number % 10;
                }
                number /= 10;
            }
            return max;
        }
    }
}
