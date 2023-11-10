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

           
        }

        Console.WriteLine("Работа завершена");
    }

    static double Evaluate(string expression)
    {
        return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
    }
}
