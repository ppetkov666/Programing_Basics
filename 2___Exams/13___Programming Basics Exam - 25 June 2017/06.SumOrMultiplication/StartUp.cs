namespace _06.SumOrMultiplication
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a < b && b < c)
                        {
                            if (a + b + c == controlNumber)

                            {
                                Console.WriteLine($"{a} + {b} + {c} = { controlNumber}");
                                counter++;
                            }
                        }
                        if (a > b && b > c)
                        {
                            if (a * b * c == controlNumber)

                            {
                                Console.WriteLine($"{a} * {b} * {c} = { controlNumber}");
                                counter++;
                            }
                        }

                    }
                }

            }
            if (counter == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
