namespace _03._Powers_of_Two
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
