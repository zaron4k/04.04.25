using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Product : Tovar
    {
        public Product(string name, double price, DateTime productionDate, DateTime expiryDate)
        {
            Name = name;
            Price = price;
            ProductionDate = productionDate;
            ExpiryDate = expiryDate;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Продукт: {Name}, Цена: {Price:C}, Дата производства: {ProductionDate.ToShortDateString()}, Срок годности: {ExpiryDate.ToShortDateString()}");
        }

        public override bool IsExpired()
        {
           return CheckExpiry();
        }
    }
}
