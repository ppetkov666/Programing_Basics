namespace _03._Vacation
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double olders = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double taxOlders = 0;
            double taxStudents = 0;

            if (transport == "train")
            {
                if (olders + students >= 50)
                {
                    taxOlders = 24.99 * 0.5;
                    taxStudents = 14.99 * 0.5;
                }
                else
                {
                    taxOlders = 24.99;
                    taxStudents = 14.99;
                }
            }
            if (transport == "bus")
            {
                taxOlders = 32.50;
                taxStudents = 28.50;
            }
            if (transport == "boat")
            {
                taxOlders = 42.99;
                taxStudents = 39.99;
            }
            if (transport == "airplane")
            {
                taxOlders = 70.00;
                taxStudents = 50.00;
            }
            double olderTotal = olders * taxOlders;
            double studentTotal = students * taxStudents;
            double total = (olderTotal + studentTotal) * 2;
            double hotelTax = nights * 82.99;
            double comission = (total + hotelTax) * 0.10;
            double fullFinal = comission + total + hotelTax;
            Console.WriteLine($"{fullFinal:f2}");
        }
    }
}
