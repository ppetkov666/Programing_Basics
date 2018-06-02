namespace _04._SoftUni_Camp
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numOfGroups = int.Parse(Console.ReadLine());

            double car = 0;
            double microbus = 0;
            double smallBus = 0;
            double bigBuss = 0;
            double train = 0;
            double sum = 0;
            for (int i = 0; i < numOfGroups; i++)
            {
                int peoplePerGroup = int.Parse(Console.ReadLine());
                sum += peoplePerGroup;
                if (peoplePerGroup <= 5)
                {
                    car += peoplePerGroup;
                }
                else if (peoplePerGroup > 5 && peoplePerGroup <= 12)
                {
                    microbus += peoplePerGroup;
                }
                else if (peoplePerGroup > 12 && peoplePerGroup <= 25)
                {
                    smallBus += peoplePerGroup;
                }
                else if (peoplePerGroup > 25 && peoplePerGroup <= 40)
                {
                    bigBuss += peoplePerGroup;
                }
                else if (peoplePerGroup > 40)
                {
                    train += peoplePerGroup;
                }

            }
            double carsum = (car / sum) * 100;
            double microbusSum = (microbus / sum) * 100;
            double smallBusSum = (smallBus / sum) * 100;
            double bigBusSum = (bigBuss / sum) * 100;
            double trainSum = (train / sum) * 100;

            Console.WriteLine($"{carsum:f2}%");
            Console.WriteLine($"{microbusSum:f2}%");
            Console.WriteLine($"{smallBusSum:f2}%");
            Console.WriteLine($"{bigBusSum:f2}%");
            Console.WriteLine($"{trainSum:f2}%");
        }
    }
}
