namespace _07.Christmas_Tree
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                string spaces = new string(' ', n - i);
                string asterisk = new string('*', i);
                string symbol = " | ";
                Console.WriteLine($"{spaces}{asterisk}{symbol}{asterisk}");
            }
        }
    }
}
