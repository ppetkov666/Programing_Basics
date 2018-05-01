namespace _09._Sum_Digits
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int digit = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                int onedigit = digit % 10;
                digit = digit / 10;
                sum += onedigit;
            } while (digit > 0);
            Console.WriteLine(sum);
        }
    }
}
