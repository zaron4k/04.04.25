using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    abstract class Tovar
    {
        public string Name
        {
            get; set;
        }
        protected double Price
        {
            get; set;
        }
        public DateTime ProductionDate
        {
            get; set;
        }
        public DateTime ExpiryDate
        {
            get; set;
        }
        public abstract void PrintInfo();
        public abstract bool IsExpired();

        protected bool CheckExpiry()
        {
            return DateTime.Now > ExpiryDate;
        }
        

    }
}
