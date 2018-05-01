namespace _01._Numbers_1_till_N_with_Step_3
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
