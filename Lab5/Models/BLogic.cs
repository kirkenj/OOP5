using System;
using System.Collections.Generic;
using System.Text;


namespace Lab5.Models
{
    static class BLogic
    {
        public static bool HasMoreEven(int num)//returns true if there're more even then odd numbers in passed variable
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
        static public string IsDominatedByOddOrEvenNumbers(int number)
        {
            int[] frequency = new int[2];
            do
            {
                ++frequency[number & 1];
            } while ((number /= 10) != 0);
            return frequency[0] > frequency[1] ? "Even numbers prevail!" : frequency[0] < frequency[1] ? "Odd numbers prevail!" : "The number of even is equal to odd!";
        }
    }
}
