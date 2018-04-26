namespace _07._Left_and_Right_Sum
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            for (int i = 1; i <= n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());

                left += n1;
            }
            for (int i = 1; i <= n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                right += n2;
            }
            int diff = Math.Abs(left - right);
            if (left == right) Console.WriteLine($"Yes, sum={left}");
            else Console.WriteLine($"No, diff={diff}");
        }
    }
}
