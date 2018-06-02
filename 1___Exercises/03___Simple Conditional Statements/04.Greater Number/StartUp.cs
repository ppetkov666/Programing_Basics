namespace _04.Greater_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number > number2)
            {
                Console.WriteLine(number);
            }     
            else
                Console.WriteLine(number2);
        }
    }
}
