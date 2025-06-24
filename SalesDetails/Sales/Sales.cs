using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public class Sales
    {
        private string customerName;
        private string Address;
        private DateTime datetime;
        private int price;
        private int quantity;

        public Sales(string customerName, string Address, DateTime datetime, int price, int quantity)
        {
            this.customerName = customerName;
            this.Address = Address;
            this.datetime = datetime;
            this.price = price;
            this.quantity = quantity;
        }
        public int GetPrice()
        {
            return price * quantity;
        }
        public string GetIvoice()
        {
            string s = "";
            s += $"{customerName}";
            s += $"\t\t{Address}";
            s += $"\t\t{DateTime.Now}";
            s += $"\t{price}\t";
            s += $"\t\t{quantity}";
            s += $"\t\t{GetPrice()}";
            return s;
        }
    }
}
