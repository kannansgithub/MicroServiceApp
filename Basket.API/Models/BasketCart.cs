using System.Collections.Generic;
using System.Linq;

namespace Basket.API.Models
{
    public class BasketCart
    {
        public string UserName { get; set; }
        public IEnumerable<BasketCartItem> Items { get; set; } = new List<BasketCartItem>();
        public BasketCart(string username)
        {
            UserName = username;
        }
        public BasketCart()
        {

        }
        public decimal TotalPrice
        {
            get
            {
                return Items.Sum(x => x.Price * x.Quantity);
            }
        }
    }
}
