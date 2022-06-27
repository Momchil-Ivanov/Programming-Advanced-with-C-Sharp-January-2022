using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> productShops = 
                new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                var splitted = input.Split(", ");
                var shop = splitted[0];
                var product = splitted[1];
                var price = double.Parse(splitted[2]);

                if (!productShops.ContainsKey(shop))
                {
                    productShops.Add(shop, new Dictionary<string, double>());
                }

                productShops[shop].Add(product, price);
                input = Console.ReadLine(); 
            }

            productShops = productShops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var shop in productShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}