namespace _06._Group_Name
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char letterBIG = char.Parse(Console.ReadLine().ToUpper());
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (char big = 'A'; big <= letterBIG; big++)
            {
                for (char letterfirst = 'a'; letterfirst <= letter1; letterfirst++)
                {
                    for (char lettersecond = 'a'; lettersecond <= letter2; lettersecond++)
                    {
                        for (char letterthree = 'a'; letterthree <= letter3; letterthree++)
                        {
                            for (int number = 0; number <= n; number++)
                            {
                                if (big == letterBIG && letterfirst == letter1 && lettersecond == letter2 && letterthree == letter3 && number == n)
                                {
                                    Console.WriteLine(counter);
                                    return;
                                }

                                else
                                {
                                    counter++;

                                    //Console.Write($"{big}{letterfirst}{lettersecond}{letterthree}{number} ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
