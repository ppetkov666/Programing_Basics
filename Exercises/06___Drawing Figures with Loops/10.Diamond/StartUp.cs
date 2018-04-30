namespace _10.Diamond
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char stars = '*';
            int starscounter = 1;
            if (n % 2 == 0) starscounter = 2;
            char dashes = '-';
            int dashcounter = (n - starscounter) / 2;

            string firstandlastrow = "{0}{1}{0}";
            string finalFandLrow = string.Format(firstandlastrow,
                                    new string(dashes, dashcounter),
                                    new string(stars, starscounter));
            int middledashes = 1;
            if (n % 2 == 0) middledashes = 2;
            string uppartformat = "{0}*{1}*{0}";
            string downpartformat = uppartformat;
            if (n > 2)
                Console.WriteLine(finalFandLrow);

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                dashcounter--;
                string UPPART = string.Format(uppartformat,
                                new string(dashes, dashcounter),
                                new string(dashes, middledashes));
                Console.WriteLine(UPPART);
                middledashes += 2;
            }
            for (int i = 0; i < (n - 1) / 2 - 1; i++)
            {
                middledashes -= 4;
                dashcounter++;
                string DOWN = string.Format(downpartformat,
                                new string(dashes, dashcounter),
                                new string(dashes, middledashes));
                Console.WriteLine(DOWN);
                middledashes += 2;
            }
            Console.WriteLine(finalFandLrow);
        }
    }
}
