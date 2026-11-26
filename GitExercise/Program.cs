using System;
using System.Globalization;

namespace GitExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine()?.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double a))
            {
                Console.WriteLine("Ошибка: некорректное число.");
                return;
            }

            Console.Write("Введите операцию (+, -, *, /): ");
            string? op = Console.ReadLine()?.Trim();

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine()?.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double b))
            {
                Console.WriteLine("Ошибка: некорректное число.");
                return;
            }

            double result;
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Ошибка: неизвестная операция.");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
