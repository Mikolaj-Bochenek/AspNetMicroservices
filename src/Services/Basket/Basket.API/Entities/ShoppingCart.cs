using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Items = new List<ShoppingCartItem>();
        }
        
        public ShoppingCart(string username)
        {
            Username = username;
            Items = new List<ShoppingCartItem>();
        }

        public string Username { get; set; }
        public List<ShoppingCartItem> Items { get; set; }
        public decimal TotalPrice
        { 
            get
            {
                decimal totalPrice = 0;
                Items.ForEach(item => totalPrice += item.Price * item.Quantity);
                return totalPrice;
            }
        }
    }
}