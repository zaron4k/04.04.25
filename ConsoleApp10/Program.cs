using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Молоко", 50, new DateTime(2024, 1, 1), new DateTime(2025, 1, 1));
            Product product2 = new Product("Хлеб", 20, new DateTime(2024, 3, 1), new DateTime(2024, 4, 1));
            List<Product> kitProducts = new List<Product> { product1, product2 };
            Kit kit1 = new Kit("Комплект продуктов", 100, kitProducts, new DateTime(2024, 4, 4), new DateTime(2025, 4, 4));
            Party party1 = new Party("Партия молока", 50, 10, new DateTime(2024, 1, 1), new DateTime(2025, 1, 1));
   
            List<Tovar> tovars = new List<Tovar> { product1, product2, kit1, party1 };

            Console.WriteLine("Информация о товарах:");
            foreach (var tovar in tovars)
            {
                tovar.PrintInfo();
                Console.WriteLine(tovar.IsExpired() ? "Товар просрочен." : "Товар не просрочен.");
                Console.WriteLine();
            }

            Console.WriteLine("Просроченные товары");
            foreach (var tovar in tovars)
            {
                if (tovar.IsExpired())
                {
                    Console.WriteLine($"{tovar.Name} - Просрочен");
                }
            }
            Console.Read();
        }
    }
}
