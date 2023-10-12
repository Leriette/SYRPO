using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор");
        Console.Write("Введите выражение: ");
        string input = Console.ReadLine();

        try
        {
            double result = Evaluate(input);
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static double Evaluate(string expression)
    {
        return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
    }
}
