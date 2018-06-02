namespace _10._Half_Sum_Element
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int diff = 0;
            int maxnumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxnumber) maxnumber = number;
                sum = sum + number;
            }
            diff = Math.Abs(sum - maxnumber * 2);
            if (maxnumber * 2 == sum)
            {
                Console.WriteLine($"Yes,Sum={maxnumber}");
            }
            else
                Console.WriteLine($"No Diff={diff}");
        }
    }
}
