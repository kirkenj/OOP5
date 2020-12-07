using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class DLogic
    {
        public static bool IsPrime(uint a)
        {
            uint i;
            if (a == 2)
                return true;
            if (a == 0 || a == 1 || a % 2 == 0)
                return false;
            for (i = 3; i * i <= a && a % i == 0; i += 2)
                ;
            return i * i > a;
        }


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
