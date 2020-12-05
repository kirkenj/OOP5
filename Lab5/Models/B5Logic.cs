using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class B5Logic
    {
        static int DECIMAL_NOTATION_BASE = 10;
        public static bool IsMoreEvenInNum(int num)
        {
            int digitCounter = 0;
            int evenCounter = 0;
            int bufer;
            while (num > 0)
            {
                bufer = num % DECIMAL_NOTATION_BASE;
                if (bufer % 2 == 0)
                {
                    evenCounter++;
                }
                digitCounter++;
                num /= DECIMAL_NOTATION_BASE;
            }
            return (digitCounter - evenCounter < evenCounter);
        }
    }
}
