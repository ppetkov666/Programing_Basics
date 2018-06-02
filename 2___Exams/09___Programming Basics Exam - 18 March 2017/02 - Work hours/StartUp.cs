namespace _02___Work_hours
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int sum = workers * days * 8;
            int diff = Math.Abs(sum - hours);
            if (sum >= hours)
            {
                Console.WriteLine($"{diff} hours left");
            }
            else if (sum < hours)
            {
                Console.WriteLine($"{diff} overtime");
                int penalty = diff * days;
                Console.WriteLine($"Penalties: {penalty}");
            }
        }
    }
}
