using System.Collections.Generic;
using Philips_Project.Model;

namespace Philips_Project.Services
{
    /**
    * This class has the logic to Add an item to the cart and retrieve all items from the cart.
    **/
    public class ShoppingCartService 
    {
        private readonly List<CartItem> _items = new List<CartItem>();

        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }

        public List<CartItem> GetAll()
        {
            return new List<CartItem>(_items);
        }
    }
}