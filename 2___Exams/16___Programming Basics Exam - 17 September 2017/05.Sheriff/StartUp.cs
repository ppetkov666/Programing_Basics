namespace _05.Sheriff
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dots = new string('.', ((3 * n) - 1)/2);
            //printing the first row
            Console.WriteLine($"{dots}x{dots}");          
            //printing the second row
            var dotsSecondRow = new string('.', ((3 * n) - 3) / 2);
            Console.WriteLine($"{dotsSecondRow}/x\\{dotsSecondRow}");
            //printing the third row
            Console.WriteLine($"{dotsSecondRow}x|x{dotsSecondRow}");

            var dotCounter = ((3 * n) - (2 * n) - 1)/2;
            var dot = new string('.', dotCounter);
            var xCounter = n;
            var symbolX = new string('x', xCounter);
            //printing the first partofAlgoritm
            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.Write(new string('.', dotCounter));
                Console.Write(new string('x', xCounter));
                Console.Write('|');
                Console.Write(new string('x', xCounter));
                Console.WriteLine(new string('.', dotCounter));
                dotCounter--;
                xCounter++;
            }
            dotCounter+=2;
            xCounter-=2;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('.', dotCounter));
                Console.Write(new string('x', xCounter));
                Console.Write('|');
                Console.Write(new string('x', xCounter));
                Console.WriteLine(new string('.', dotCounter));
                dotCounter++;
                xCounter--;
            }
            //printing the middle 2 rows 
            Console.WriteLine($"{dotsSecondRow}/x\\{dotsSecondRow}");
            Console.WriteLine($"{dotsSecondRow}\\x/{dotsSecondRow}");
            //printing the second partofAlgoritm
            dotCounter--;
            xCounter++;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.Write(new string('.', dotCounter));
                Console.Write(new string('x', xCounter));
                Console.Write('|');
                Console.Write(new string('x', xCounter));
                Console.WriteLine(new string('.', dotCounter));
                dotCounter--;
                xCounter++;
            }
            dotCounter += 2;
            xCounter -= 2;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('.', dotCounter));
                Console.Write(new string('x', xCounter));
                Console.Write('|');
                Console.Write(new string('x', xCounter));
                Console.WriteLine(new string('.', dotCounter));
                dotCounter++;
                xCounter--;
            }
            //printing the third row backward
            Console.WriteLine($"{dotsSecondRow}x|x{dotsSecondRow}");
            //printing the second row backward           
            Console.WriteLine($"{dotsSecondRow}\\x/{dotsSecondRow}");
            //printing the last row
            Console.WriteLine($"{dots}x{dots}");
        }
    }
}
