using System;
using System.Collections.Generic;
using ExHer_Produtos.Entities;
using System.Globalization;

namespace ExHer_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Product {i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char p = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (p == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double custom = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price,custom));
                }
                else if (p == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price,date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product obj in list)
            {
                Console.WriteLine(obj.PriceTag()) ;
            }

        }
    }
}
