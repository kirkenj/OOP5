using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class ELogic
    {
        public static bool DegreeOfTwo(int number)
        {
            while (number != 1)
            {
                if (number % 2 != 0)
                {
                    return false;
                }
                number /= 2;
            }
            return true;
        }

        public static bool DegreeOfThree(int number)
        {
            while (number != 1)
            {
                if (number % 3 != 0)
                {
                    return false;
                }
                number /= 3;
            }
            return true;
        }
    }
}
