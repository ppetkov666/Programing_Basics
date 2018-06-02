namespace _02._Scholarship
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double socialScholarshipIndex = Math.Truncate(0.35 * minimumWage);
            double excelentScholarshipIndex = Math.Truncate(25 * grade);

            if (grade < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            if (grade >= 4.50 && grade < 5.50 && income < minimumWage)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarshipIndex} BGN");
            }
            if (grade >= 4.50 && grade < 5.50 && income >= minimumWage)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            if (grade >= 5.50)
            {
                if (socialScholarshipIndex > excelentScholarshipIndex && income < minimumWage)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarshipIndex} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excelentScholarshipIndex} BGN");
                }
            }
        }
    }
}
