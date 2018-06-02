namespace Task_02_TubesInThePool
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int vPool = int.Parse(Console.ReadLine());
            int debitP1 = int.Parse(Console.ReadLine());
            int debitP2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double sumP1 = debitP1 * hours;
            double sumP2 = debitP2 * hours;
            double totalBothTubes = sumP1 + sumP2;
            double percentAmount = 0;
            if (totalBothTubes <= vPool)
            {
                double firstTube = Math.Truncate((sumP1 / totalBothTubes) * 100);
                double secondTube = Math.Truncate((sumP2 / totalBothTubes) * 100);
                percentAmount = Math.Truncate((totalBothTubes / vPool) * 100);
                Console.WriteLine
                    ($"The pool is {percentAmount}% full. Pipe 1: {firstTube}%. Pipe 2: {secondTube}%.");
            }
            else if (totalBothTubes > vPool)
            {
                double diffff = Math.Abs(vPool - totalBothTubes);
                Console.WriteLine
                    ($"For {hours} hours the pool overflows with { diffff:f1} liters.");
            }
        }
    }
}
