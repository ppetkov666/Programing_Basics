namespace _04___Bills
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int months = int.Parse(Console.ReadLine());
            double water = 20;
            double internet = 15;
            double sumElectricity = 0;
            double totalBill = 0;
            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                totalBill += (electricity + water + internet) * 1.2;
                sumElectricity += electricity;
            }
            double water1 = water * months;
            double internet1 = internet * months;
            double totalSum = (sumElectricity + water1 + internet1 + totalBill) / months;

            Console.WriteLine($"Electricity: {sumElectricity:f2} lv");
            Console.WriteLine($"Water: {water1:f2} lv");
            Console.WriteLine($"Internet: {internet1:f2} lv");
            Console.WriteLine($"Other: {totalBill:f2} lv");
            Console.WriteLine($"Average: {totalSum:f2} lv");
        }
    }
}
