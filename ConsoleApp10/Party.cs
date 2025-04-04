using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Party : Tovar
    {
        public int Quantity { get; set; }
        public Party(string name, double price, int quantity, DateTime productionDate, DateTime expiryDate)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            ProductionDate = productionDate;
            ExpiryDate = expiryDate;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Продукт: {Name}, Цена: {Price:C}, Количество: {Quantity}, Дата производства: {ProductionDate.ToShortDateString()}, Срок годности: {ExpiryDate.ToShortDateString()}");
        }
        public override bool IsExpired()
        {
            return CheckExpiry();
        }
    }
}
