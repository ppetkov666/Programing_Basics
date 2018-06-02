namespace _02._Choreography
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double numSteps = double.Parse(Console.ReadLine());
            double dancersNums = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double percentage = (numSteps / days) / numSteps * 100;
            percentage = Math.Ceiling(percentage);
            double stepperDancer = percentage / dancersNums;
            if (percentage <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepperDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepperDancer:f2}% steps to be learned per day.");
            }
        }
    }
}
