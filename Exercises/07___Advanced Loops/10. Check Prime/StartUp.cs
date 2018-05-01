namespace _10._Check_Prime
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool prime = true;
            if (number <= 1) Console.WriteLine("Not Prime");
            else if (number == 2) Console.WriteLine("Prime");
            else
            {
                for (int i = 2; ; i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime) Console.WriteLine("Prime");
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}
