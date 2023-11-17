using System;

class Program
{
    static void Main()
    {
<<<<<<< HEAD
=======
        Console.WriteLine("Калькулятор");
>>>>>>> a66b24e1df527dbeae56eb738537478dc5165e42

<<<<<<< HEAD
        while (true)
        {
            Console.Write("Введите выражение (или 'exit' для выхода): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

           
        }

        Console.WriteLine("Работа завершена.");
    }

    static double Evaluate(string expression)
    {
        return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
    }
}
