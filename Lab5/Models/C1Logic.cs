using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class C1Logic
    {
        public static bool IsDecreasingSequence(int num)
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
    }
}
