using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Kit : Tovar
    {
        public List<Product> Products
        {
            get; set;
        }
        public Kit(string name, double price, List<Product> products, DateTime productionDate, DateTime expiryDate)
        {
            Name = name;
            Price = price;
            Products = products;
            ProductionDate = productionDate;
            ExpiryDate = expiryDate;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Комплект: {Name}, Цена: {Price:C}, Дата производства: {ProductionDate.ToShortDateString()}, Срок годности {ExpiryDate.ToShortDateString()}");
            Console.WriteLine("Состав комплекта:");
            foreach (var product in Products)
            {
                product.PrintInfo();
            }
        }
        public override bool IsExpired()
        {
            return CheckExpiry();
        }
    }
}
