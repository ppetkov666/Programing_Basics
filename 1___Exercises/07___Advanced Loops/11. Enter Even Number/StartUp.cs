namespace _11._Enter_Even_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.Write("Enter even number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; ; i++)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Enter even number: ");
                    number = int.Parse(Console.ReadLine());
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {number}");
                    break;
                }

            }
        }
    }
}
