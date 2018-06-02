namespace _05_Stop
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char slash = '\\';
            int counterSlash = 2;
            int counterDots = n;
            int counterDotSecond = 1;
            int counterMiddleUnderLines = 2 * n - 1;
            int counterXXX = 4 * n - 3;
            char dot = '.';
            char under = '_';
            string format = "{0}{1}{0}";
            string format2 = "{0}//{1}{2}{0}";
            string format3 = "//{0}STOP!{0}{1}";
            string format4 = "{0}{1}//";
            string format5 = "{0}{1}{2}//{0}";
            
            string finalformat = string.Format(format,
                new string(dot, n + 1),
                new string(under, 2 * n + 1));
            string finalformatSTOP = string.Format(format3,
                   new string(under, (4 * n - 6) / 2),
                   new string(slash, 2));
            string finalformat4 = string.Format(format4,
                new string(slash, 2),
                new string(under, 4 * n - 1));


            Console.WriteLine(finalformat);
            for (int i = 0; i < n; i++)
            {
                string finalformat1 = string.Format(format2,
                new string(dot, counterDots),
                new string(under, counterMiddleUnderLines),
                new string(slash, counterSlash));
                Console.WriteLine(finalformat1);
                counterDots--;
                counterMiddleUnderLines += 2;
            }

            Console.WriteLine(finalformatSTOP);
            Console.WriteLine(finalformat4);
            for (int i = 0; i < n - 1; i++)
            {
                string finalformat5 = string.Format(format5,
                                   new string(dot, counterDotSecond),
                                   new string(slash, 2),
                                   new string(under, counterXXX));
                Console.WriteLine(finalformat5);
                counterDotSecond++;
                counterXXX -= 2;
            }
        }
    }
}
