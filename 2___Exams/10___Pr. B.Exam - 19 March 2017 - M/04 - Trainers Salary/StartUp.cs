namespace _04___Trainers_Salary
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double numOfLectures = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double lecturePrice = budget / numOfLectures;

            double totalJelev = 0;
            double totalSumRoyal = 0;
            double totalSumRoli = 0;
            double totalSumTrofon = 0;
            double totalSumSino = 0;
            double totalElseSum = 0;

            for (int i = 1; i <= numOfLectures; i++)
            {
                string lector = Console.ReadLine().ToLower();
                if (lector == "jelev")
                {

                    totalJelev++;
                }
                else if (lector == "royal")
                {

                    totalSumRoyal++;
                }
                else if (lector == "roli")
                {

                    totalSumRoli++;
                }
                else if (lector == "trofon")
                {

                    totalSumTrofon++;
                }
                else if (lector == "sino")
                {

                    totalSumSino++;
                }
                else
                {

                    totalElseSum++;
                }
            }

            Console.WriteLine($"Jelev salary: {totalJelev * lecturePrice:f2} lv");
            Console.WriteLine($"RoYaL salary: {totalSumRoyal * lecturePrice:f2} lv");
            Console.WriteLine($"Roli salary: {totalSumRoli * lecturePrice:f2} lv");
            Console.WriteLine($"Trofon salary: {totalSumTrofon * lecturePrice:f2} lv");
            Console.WriteLine($"Sino salary: {totalSumSino * lecturePrice:f2} lv");
            Console.WriteLine($"Others salary: {totalElseSum * lecturePrice:f2} lv");
        }
    }
}
