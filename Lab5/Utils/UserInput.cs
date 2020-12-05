using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab5.Utils
{
    static class UserInput
    {
        public static int GetInt()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input correct num");
                }
            }
        }
    }
}
