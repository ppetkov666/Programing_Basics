namespace _06.The_song_of_the_wheels
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            string password = null;
            for (int a = 1; a < 10; a++)               
            {
                for (int b = 1; b < 10; b++)
                {
                    for (int c = 1; c < 10 ; c++)
                    {
                        for (int d = 1; d < 10; d++)
                        {
                            if (a<b && c>d)
                            {
                                if (a*b + c*d ==controlNumber)
                                {
                                    counter += 1;
                                    Console.Write($"{a}{b}{c}{d} ");
                                    if (counter == 4)
                                    {
                                         password = string.Format($"{a}{b}{c}{d}");
                                    }
                                }                               
                            }
                        }
                    }
                }
            }
            if (password !=null)
            {
                Console.WriteLine();
                Console.Write("Password: " + password);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.Write("No!");
                Console.WriteLine();
            }           
        }
    }
}
