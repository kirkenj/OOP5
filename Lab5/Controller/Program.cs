using Lab5.View;
using Lab5.Models;
namespace Lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 3258;
            OutInConsole.Print(ALogic.GetSumOfDigits(number));
            OutInConsole.Print(ALogic.GetLength(number));
            OutInConsole.Print($"Number: {number}\tAmount of numbers: {ALogic.AmountElement(number)}");
            OutInConsole.Print(BLogic.HasMoreEven(number));
            OutInConsole.Print(BLogic.HasOneEven(number));
            OutInConsole.Print($"Number: {number}\tAnswer: {BLogic.IsDominatedByOddOrEvenNumbers(number)}");
            OutInConsole.Print(CLogic.IsDecreasingSequence(number));
            OutInConsole.Print(CLogic.IsDecreasingSequence(951));
            OutInConsole.Print(CLogic.ReverseNumber(number));
            OutInConsole.Print($"Number: {number}\tAnswer: {(number == 0) || (CLogic.CheckingForPalindrome(number, 0)) == number}");
            OutInConsole.Print(DLogic.FindMaxDigit(number));
            OutInConsole.Print(DLogic.IsPrime(4));
            OutInConsole.Print(DLogic.IsPrime(3));
            OutInConsole.Print($"Number: {number}\tAmount of numbers: {DLogic.Element(number)}");
            OutInConsole.Print(ELogic.DegreeOfThree(18));
            OutInConsole.Print(ELogic.DegreeOfThree(27));
            OutInConsole.Print(ELogic.DegreeOfTwo(27));
            OutInConsole.Print(ELogic.DegreeOfTwo(64));
            OutInConsole.Print(ELogic.GetTriboncchiWithIndex(8));
            OutInConsole.Print($"Number: {number}\tAnswer: {ELogic.NumberFibonacci(number, 1, 0)}");
        }
    }
}