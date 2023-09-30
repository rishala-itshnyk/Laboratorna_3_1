using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть значення x:");
        double x = double.Parse(Console.ReadLine());

        double A = 0;
        double B = 0;
        double y = 0;   

        // Обчислення значення A - функціонально сталої частини виразу
        A = 1.0 / Math.Abs(x + 2) + 1;

        // Спосіб 1: розгалуження в скороченій формі
        if (x < 1)
        {
            B = 7 * x * x + x - 8;
        }
        if (x >= 1 && x <= 4)
        {
            B = 1 / Math.Tan((x + 4) / Math.Sqrt(11)) + 3;
        }
        if (x > 4)
        { 
            B = Math.Sqrt(1 + Math.Abs(Math.Pow(Math.Cos(x), 3)));
        }

        // Обчислення значення y (Спосіб 1)
        y = A + B;
        Console.WriteLine($"Спосіб 1: y = {y}");

        // Спосіб 2: розгалуження в повній формі
        if (x < 1)
        {
            B = 7 * x * x + x - 8;
        }
        else
        {
            if (x > 4)
            {
                B = Math.Sqrt(1 + Math.Abs(Math.Pow(Math.Cos(x), 3)));
            }
            else
            {
                B = 1 / Math.Tan((x + 4) / Math.Sqrt(11)) + 3;
            }
        }

        // Обчислення значення y (Спосіб 2)
        y = A + B;
        Console.WriteLine($"Спосіб 2: y = {y}");
    }
}