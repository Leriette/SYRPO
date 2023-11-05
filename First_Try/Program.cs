using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");

        while (true)
        {
            Console.Write("Введите выражение (или 'exit' для выхода): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            try
            {
                double result = Evaluate(input);
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Некорректный формат ввода.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        Console.WriteLine("Работа завершена.");
    }

    static double Evaluate(string expression)
    {
        return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
    }
}
