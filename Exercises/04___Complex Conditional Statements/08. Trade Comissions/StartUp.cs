namespace _08._Trade_Comissions
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double result = -1.0;
            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500) result = sales * 0.05;
                if (sales > 500 && sales <= 1000) result = sales * 0.07;
                if (sales > 1000 && sales <= 10000) result = sales * 0.08;
                if (sales > 10000) result = sales * 0.12;
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500) result = sales * 0.045;
                if (sales > 500 && sales <= 1000) result = sales * 0.075;
                if (sales > 1000 && sales <= 10000) result = sales * 0.1;
                if (sales > 10000) result = sales * 0.13;
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) result = sales * 0.055;
                if (sales > 500 && sales <= 1000) result = sales * 0.08;
                if (sales > 1000 && sales <= 10000) result = sales * 0.12;
                if (sales > 10000) result = sales * 0.145;
            }
            if (result < 0) Console.WriteLine("error");
            else
                Console.WriteLine($"{result:f2}");
        }
    }
}
