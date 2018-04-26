namespace _15._3_Equal_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 && num1 == num3)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
