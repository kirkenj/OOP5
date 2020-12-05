using Lab5.View;
using Lab5.Utils;
using Lab5.Models;
namespace Lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            OutInConsole.Print(CLogic.ReverseNumber(UserInput.GetInt()));
            Meow.meow();
        }
    }
}