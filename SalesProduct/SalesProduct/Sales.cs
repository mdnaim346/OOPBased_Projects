using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProduct
{
    public class Sales
    {
        public string productName;
        public string productId;
        public DateTime date;
        public int price;
        public int quantity;

        public void SetPrice(int price)
        {
            this.price = price;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetTotalPrice()
        {
            return price * quantity;
        }
    }
}
