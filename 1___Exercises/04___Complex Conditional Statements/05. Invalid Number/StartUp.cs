namespace _05._Invalid_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double digit = double.Parse(Console.ReadLine());
            bool valid = (digit >= 100 && digit <= 200) || digit == 0;
            if (!valid) Console.WriteLine("invalid");
        }
    }
}
