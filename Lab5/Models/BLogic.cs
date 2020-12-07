using System;
using System.Collections.Generic;
using System.Text;


namespace Lab5.Models
{
    static class BLogic
    {
        public static bool IsMoreEvenInNum(int num)//returns true if there're more even then odd numbers in passed variable
        {
            int digitCounter = 0;
            int evenCounter = 0;
            int bufer;
            while (num > 0)
            {
                bufer = num % 10;
                if (bufer % 2 == 0)
                {
                    evenCounter++;
                }
                digitCounter++;
                num /= 10;
            }
            return (digitCounter - evenCounter < evenCounter);
        }


        public static bool HasOneEven(int number)//returns true is one even number is found into passed variable
        {
            while (number != 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
