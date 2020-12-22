using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    static class ELogic
    {
        public static int GetTriboncchiWithIndex(int index)//finds a number in tribonacchi sequence with sent index
        {
            List<int> tribonachhiList = new List<int> { 0, 0, 1 };
            int currentIndex = tribonachhiList.Count - 1;
            if (index < 0)
            {
                return -1;
            }
            if (index <= currentIndex)
            {
                return tribonachhiList[index];
            }
            while (currentIndex < index)
            {
                currentIndex++;
                tribonachhiList.Add(tribonachhiList[currentIndex - 1] + tribonachhiList[currentIndex - 2] + tribonachhiList[currentIndex - 3]);
            }
            return tribonachhiList[currentIndex];
        }

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
        static public string NumberFibonacci(int number, int x1, int num)
        {
            int x2 = 0;
            for (int i = 0; i < number - 1; i++)
            {
                x2 = x1 + num;
                num = x1;
                x1 = x2;
            }
            return $"Serial number {number} in the Fibonacci series corresponds to the number {x2}";
        }
    }
}
