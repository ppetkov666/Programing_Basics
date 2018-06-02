namespace _06._Max_Combination
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int battles = 0;
            for (int i = begining; i <= Math.Max(begining, end); i++)
            {
                for (int y = begining; y <= Math.Max(begining, end); y++)
                {
                    battles++;
                    if (battles > max)
                    {

                        break;
                    }
                    else
                    {
                        Console.Write($"<{i}-{y}>");

                    }
                }
            }
        }
    }
}
