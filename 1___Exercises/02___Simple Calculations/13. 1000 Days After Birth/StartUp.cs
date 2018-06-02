namespace _13._1000_Days_After_Birth
{
    using System;
    using System.Globalization;

    class StartUp
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime formatedDate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            DateTime thousandDaysLater = formatedDate.AddDays(999);
            Console.WriteLine(thousandDaysLater.ToString("dd-MM-yyyy"));
        }
    }
}
