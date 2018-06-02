namespace _08._Odd_Even_Sum
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    even += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    odd += num;
                }
            }
            if (even == odd)
                Console.WriteLine($"Yes,sum={even}");
            else
            {
                int diff = Math.Abs(even - odd);
                Console.WriteLine($"No,Diff={diff}");
            }
        }
    }
}
