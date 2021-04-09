using System;

namespace CashRegisterP5
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchaseprice = money("purchase price: ");
            double paymentprice = money("payment price: ");
            double change = paymentprice - purchaseprice;
            Console.WriteLine($"Your change is ${change}");
            Precise(change);
        }  

        static double money(string prompt)
        {
            double promptedprice = 0;
            bool amount2 = true;
            while (amount2 == true || promptedprice <=0)
            {
                try
                {
                    Console.Write(prompt);
                    promptedprice = double.Parse(Console.ReadLine());
                    if (promptedprice <= 0)
                    {
                        Console.WriteLine("Enter a price greater than zero.");
                    }
                    amount2 = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("You can only enter numbers");
                }
            }
            Console.WriteLine();
            return promptedprice;
        }
        static double Calculatechange(double change, double denomination, string money)
        {
            int leftover = (int)(change / denomination);
            double remainder = change % denomination;
            if (leftover > 0)
            {
                Console.WriteLine($"You will receive {leftover}{money}");
            }
            return Math.Round(change % denomination, 2);
        }
        static void Precise(double change)
        {
            change = Calculatechange(change, 20.0, " twenties");
            change = Calculatechange(change, 10.0, " tens");
            change = Calculatechange(change, 5.0, " fives");
            change = Calculatechange(change, 1.0, " ones");
            change = Calculatechange(change, 0.25, " quarties");
            change = Calculatechange(change, 0.10, " dimes");
            change = Calculatechange(change, 0.05, " nickles");
            change = Calculatechange(change, 0.01, " pennies");
        }
    }
}
