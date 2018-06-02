namespace _06._Battles
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int pokemonPlayer1 = int.Parse(Console.ReadLine());
            int pokemonPlayer2 = int.Parse(Console.ReadLine());
            int maxbattles = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 1; i <= pokemonPlayer1; i++)
            {
                for (int a = 1; a <= pokemonPlayer2; a++)
                {
                    counter++;

                    if (counter <= maxbattles)
                    {
                        Console.Write($"({i} <-> {a}) ");
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
