using System;
using System.Linq;

namespace linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Напишите задачку пример(sd2d+fsgd3f): ");
                var calcString = Console.ReadLine();
                var sum = CalculateString(calcString);
                Console.WriteLine(sum);
            }
        }

        static string CalculateString(string calcI)
        {
            double sum = 0;
            var op = calcI.Where(x => x == '*' || x == '-' || x == '+' || x == '/').FirstOrDefault();
            var results = GetNumbersFromString(calcI,op);
            switch (op.ToString())
            {
                case "*":
                    sum = Converter(results[0]) * Converter(results[1]);
                    break;
                case "-":
                    sum = Converter(results[0]) - Converter(results[1]);
                    break;
                case "+":
                    sum = Converter(results[0]) + Converter(results[1]);
                    break;
                case "/":
                    sum = Converter(results[0]) / Converter(results[1]);
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            return $"Result: {Math.Round(sum)}";
        }

        static string[] GetNumbersFromString(string calcI,char op)
        {
            return string.Join("", calcI.ToCharArray().Where(x => Char.IsDigit(x) || x == '*' || x == '-' || x == '+' || x == '/' || x == '.')).Split(op);
        }

        static double Converter(string convertToDouble)
        {
            return double.Parse(convertToDouble);
        }
    }
}
