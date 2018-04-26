namespace _07.Sum_Seconds
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int time = int.Parse(Console.ReadLine());
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());

            int sum = time + time1 + time2;
            int min = sum / 60;
            int sec = sum % 60;
            if (sec < 10)
                Console.WriteLine("{0}:0{1}", min, sec);
            else
                Console.WriteLine("{0}:{1}", min, sec);
        }
    }
}
