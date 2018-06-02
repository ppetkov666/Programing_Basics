namespace _03._Match_Tickets
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToUpper();
            double numOfPeople = double.Parse(Console.ReadLine());

            double transportExpenses = 0;
            double ticketPrice = 0;

            if (numOfPeople >= 1 && numOfPeople <= 4)
            {
                transportExpenses += budget * 0.75;
            }
            else if (numOfPeople >= 5 && numOfPeople <= 9)
            {
                transportExpenses += budget * 0.60;
            }
            else if (numOfPeople >= 10 && numOfPeople <= 24)
            {
                transportExpenses += budget * 0.50;
            }
            else if (numOfPeople >= 25 && numOfPeople <= 49)
            {
                transportExpenses += budget * 0.40;
            }
            else if (numOfPeople >= 50)
            {
                transportExpenses += budget * 0.25;
            }

            if (category == "VIP") ticketPrice = 499.99;
            if (category == "NORMAL") ticketPrice = 249.99;

            double rest = budget - transportExpenses;
            double expences = numOfPeople * ticketPrice;

            if (rest >= expences)
            {
                double diff = rest - expences;
                Console.WriteLine($"Yes! You have {diff:f2} leva left.");
            }
            else
            {
                double diff = expences - rest;
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }
        }
    }
}
