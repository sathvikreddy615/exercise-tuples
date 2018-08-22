using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>()
            {
                ("Hammer", 9, 25),
                ("Nails", 7, 100)
            };
            transactions.Add(("Bandaids", 6, 250));

            (string product, int amount, int quantity) staples = ("Staples", 4, 50);
            transactions.Add(staples);

            // (string product, int amount, int quantity) nails = ("Nails", 7, 100);
            // (string product, int amount, int quantity) nailGun = ("Nail Gun", 180, 1);
            // (string product, int amount, int quantity) bandaids = ("Bandaids", 6, 250);

            // transactions.Add(hammer);
            // transactions.Add(nails);
            // transactions.Add(nailGun);

            int TotalProductsSold = 0;
            double TotalRevenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                TotalProductsSold += t.quantity;
                TotalRevenue += t.quantity * t.amount;
            }

            Console.WriteLine($"We sold {TotalProductsSold} products for a total revenue of ${TotalRevenue}");
        }
    }
}




