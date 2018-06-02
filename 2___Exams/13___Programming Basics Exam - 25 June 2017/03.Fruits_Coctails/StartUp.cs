namespace _03.Fruits_Coctails
{
    using System; 
    class StartUp
    {
        static void Main()
        {
            string fruit = Console.ReadLine().ToLower();
            string size = Console.ReadLine().ToLower();
            int drinks = int.Parse(Console.ReadLine());

            double smallCocktail = 2;
            double bigCocktail = 5;
            if (size == "small")
            {
                if (fruit == "watermelon") smallCocktail *= 56 * drinks;
                else if (fruit == "mango") smallCocktail *= 36.66 * drinks;
                else if (fruit == "pineapple") smallCocktail *= 42.10 * drinks;
                else if (fruit == "raspberry") smallCocktail *= 20 * drinks;

                if (smallCocktail > 1000)
                {
                    smallCocktail = smallCocktail - smallCocktail * 0.5;
                }
                else if (smallCocktail >= 400 && smallCocktail <= 1000)
                {
                    smallCocktail = smallCocktail - smallCocktail * 0.15;
                }
                Console.WriteLine($"{smallCocktail:f2} lv.");

            }
            else if (size == "big")
            {
                if (fruit == "watermelon") bigCocktail *= 28.70 * drinks;
                else if (fruit == "mango") bigCocktail *= 19.60 * drinks;
                else if (fruit == "pineapple") bigCocktail *= 24.80 * drinks;
                else if (fruit == "raspberry") bigCocktail *= 15.20 * drinks;

                if (bigCocktail > 1000)
                {
                    bigCocktail = bigCocktail - bigCocktail * 0.5;
                }
                else if (bigCocktail >= 400 && bigCocktail <= 1000)
                {
                    bigCocktail = bigCocktail - bigCocktail * 0.15;
                }
                Console.WriteLine($"{bigCocktail:f2} lv.");

            }
        }
    }
}
