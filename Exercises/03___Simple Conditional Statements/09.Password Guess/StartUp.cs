namespace _09.Password_Guess
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string password = Console.ReadLine();
            if (password == "s3cr3t!P@ssw0rd")
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Wrong password!");
        }
    }
}
