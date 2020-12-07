using Lab5.View;
using Lab5.Utils;
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
            OutInConsole.Print(ELogic.GetTriboncchiWithIndex(i));
            
        }
    }
}