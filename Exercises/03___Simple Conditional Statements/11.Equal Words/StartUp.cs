namespace _11.Equal_Words
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string word = Console.ReadLine().ToLower();
            string word1 = Console.ReadLine().ToLower();
            if (word == word1) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
