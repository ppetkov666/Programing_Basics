﻿namespace _04._Concatenate_Data
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}."
                , firstname, lastname, age, town);
        }
    }
}
