namespace Task_04_Hospital
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int periodOfTime = int.Parse(Console.ReadLine());
            int patiens = 0;
            int treated = 0;
            int Untreated = 0;
            int doctorPerPerson = 7;
            for (int i = 1; i <= periodOfTime; i++)
            {
                patiens = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (treated < Untreated)
                    {
                        //diff = Math.Abs(treated - UNtreated);
                        doctorPerPerson++;
                    }
                }
                if (patiens <= doctorPerPerson) treated += patiens;
                else if (patiens > doctorPerPerson)
                {
                    treated += doctorPerPerson;
                    Untreated += patiens - doctorPerPerson;
                }
            }
            Console.WriteLine($"Treated patients: {treated }.");
            Console.WriteLine($"Untreated patients: {Untreated }.");
        }
    }
}
