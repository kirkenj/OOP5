using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class BLogic
    {
        public static string OneEven(int number)
        {
            while (number != 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    return "Number have even digit";
                }
                number /= 10;
            }
            return "No even digits on this number";
        }
    }
}
