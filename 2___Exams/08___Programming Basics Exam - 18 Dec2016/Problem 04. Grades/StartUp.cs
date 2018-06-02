using System;

namespace Problem_04._Grades
{
    class StartUp
    {
        static void Main()
        {
            double students = double.Parse(Console.ReadLine());
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;

            double counterGrades = 0;
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                counterGrades += grade;
                if (grade >= 2.00 && grade <= 2.99)
                {
                    counter1++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    counter2++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    counter3++;
                }
                else if (grade >= 5.00)
                {
                    counter4++;
                }

            }
            double average = counterGrades / students;
            double persentagepergrade1 = (counter1 / students) * 100;
            double persentagepergrade2 = (counter2 / students) * 100;
            double persentagepergrade3 = (counter3 / students) * 100;
            double persentagepergrade4 = (counter4 / students) * 100;
            Console.WriteLine($"Top students: {persentagepergrade4:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {persentagepergrade3:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {persentagepergrade2:f2}%");
            Console.WriteLine($"Fail: {persentagepergrade1:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
