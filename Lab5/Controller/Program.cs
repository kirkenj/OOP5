using Lab5.View;
using Lab5.Models;
namespace Lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 3258;
            OutInConsole.Print(ALogic.GetSymOfDigits(number));
            OutInConsole.Print(ALogic.GetLength(number));
            OutInConsole.Print(BLogic.IsMoreEvenInNum(number));
            OutInConsole.Print(BLogic.HasOneEven(number));
            OutInConsole.Print(CLogic.IsDecreasingSequence(number));
            OutInConsole.Print(CLogic.IsDecreasingSequence(951));
            OutInConsole.Print(CLogic.ReverseNumber(number));
            OutInConsole.Print(DLogic.FindMaxDigit(number));
            OutInConsole.Print(DLogic.IsPrime(4));
            OutInConsole.Print(DLogic.IsPrime(3));
            OutInConsole.Print(ELogic.DegreeOfThree(18));
            OutInConsole.Print(ELogic.DegreeOfThree(27));
            OutInConsole.Print(ELogic.DegreeOfTwo(27));
            OutInConsole.Print(ELogic.DegreeOfTwo(64));
            OutInConsole.Print(ELogic.GetTriboncchiWithIndex(8));
        }
    }
}