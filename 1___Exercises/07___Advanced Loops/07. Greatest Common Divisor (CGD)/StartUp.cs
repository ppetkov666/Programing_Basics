namespace _07._Greatest_Common_Divisor__CGD_
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a % b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            Console.WriteLine(b);
        }
    }
}
