namespace _16.Number_0_100_to_Text
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstdigit = n / 10;
            int seconddigit = n % 10;
            if (n < 0 || n > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if ( n == 0 || n == 100)
            {
                Console.WriteLine((n == 0)? "zero":"one hundred");
            }
            else
            {
                string[] ones = {"", "one", "two", "three", "four", "five", "six", "seven","eight", "nine"
                ,"ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
                string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (firstdigit < 2 || seconddigit == 0)
                {
                    Console.WriteLine((firstdigit<2)? $"{ones[n]}":$"{tens[firstdigit]}");
                }
                else
                {
                    Console.WriteLine($"{tens[firstdigit]} {ones[seconddigit]}");
                }
            }
        }
    }
}
