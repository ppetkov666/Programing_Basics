namespace _04._Cake
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int rect = width * length;
            int counter = 0;
            for (int i = 1; i <= rect; i++)
            {
                string cake = Console.ReadLine();
                if (cake == "STOP")
                {
                    int difference = Math.Abs(counter - rect);
                    Console.WriteLine($"{difference} pieces are left.");
                    break;
                }
                counter += int.Parse(cake);
                if (counter > rect)
                {
                    int diff = counter - rect;
                    Console.WriteLine($"No more cake left! You need {diff} pieces more.");
                    break;
                }
            }
        }
    }
}
