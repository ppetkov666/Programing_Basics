namespace _04._Histogram
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double num = 0;

            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    counter1++;
                    p1 = counter1 / n * 100;
                }

                else if (num >= 200 && num <= 399)
                {
                    counter2++;
                    p2 = counter2 / n * 100;
                }

                else if (num >= 400 && num <= 599)
                {
                    counter3++;
                    p3 = counter3 / n * 100;
                }

                else if (num >= 600 && num <= 799)
                {
                    counter4++;
                    p4 = counter4 / n * 100;
                }

                else if (num >= 800)
                {
                    counter5++;
                    p5 = counter5 / n * 100;
                }
            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
