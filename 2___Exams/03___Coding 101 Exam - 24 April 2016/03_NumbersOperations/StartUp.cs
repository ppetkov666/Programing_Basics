namespace _03_NumbersOperations
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();

            if (symbol == "+")
            {
                Console.Write($"{n1} + {n2} = {n1 + n2} - ");
                Console.WriteLine((n1 + n2) % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "-")
            {
                Console.Write($"{n1} - {n2} = {n1 - n2} - ");
                Console.WriteLine((n1 + n2) % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "*")
            {
                Console.Write($"{n1} * {n2} = {n1 * n2} - ");
                Console.WriteLine((n1 * n2) % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "/")
            {
                if (n2 == 0) Console.WriteLine($"Cannot divide {n1} by zero");
                else
                    Console.WriteLine($"{n1} / {n2} = {n1 / n2:0.00}");

            }
            else if (symbol == "%")
            {
                if (n2 == 0) Console.WriteLine($"Cannot divide {n1} by zero");
                else
                    Console.Write($"{n1} % {n2} = {n1 % n2}");

            }
        }
    }
}
