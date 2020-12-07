using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class CLogic
    {

        public static bool IsDecreasingSequence(int num)//returns true if the passed variable is a decreasing sequence
        {
            if (num < 10)
            {
                return false;
            }
            int prevNum = num % 10;
            num /= 10;
            while (num > 0)
            {
                if (num % 10 < prevNum)
                {
                    return false;
                }
                num /= 10;
            }
            return true;
        }
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
