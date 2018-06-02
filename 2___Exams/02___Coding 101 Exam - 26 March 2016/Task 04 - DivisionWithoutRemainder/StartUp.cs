namespace Task_04_DivisionWithoutRemainder
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double num = 0;

            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    counter1++;
                    p1 = counter1 / n * 100;
                }

                if (num % 3 == 0)
                {
                    counter2++;
                    p2 = counter2 / n * 100;
                }

                if (num % 4 == 0)
                {
                    counter3++;
                    p3 = counter3 / n * 100;
                }


            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
