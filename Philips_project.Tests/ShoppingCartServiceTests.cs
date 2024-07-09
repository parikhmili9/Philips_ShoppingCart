using Philips_Project.Model;
using Philips_Project.Services;
using System.Collections.Generic;
using Xunit;

namespace Philips_Project.Tests
{
    public class ShoppingCartServiceTests
    {
        [Fact]
        public void AddItem_ShouldAddItemToCart()
        {
            var service = new ShoppingCartService();
            var item = new CartItem { Name = "Item1", Price = 10.0, Quantity = 1 };

            service.AddItem(item);
            var items = service.GetAll();

            Assert.Single(items);
            Assert.Equal(item.Name, items[0].Name);
            Assert.Equal(item.Price, items[0].Price);
            Assert.Equal(item.Quantity, items[0].Quantity);
        }

        [Fact]
        public void GetAllItems_ShouldReturnAllItemsInCart()
        {
            var service = new ShoppingCartService();
            var item1 = new CartItem { Name = "Item1", Price = 10.0, Quantity = 1 };
            var item2 = new CartItem { Name = "Item2", Price = 20.0, Quantity = 2 };
            service.AddItem(item1);
            service.AddItem(item2);

            var items = service.GetAll();

            Assert.Equal(2, items.Count);
            Assert.Contains(item1, items);
            Assert.Contains(item2, items);
        }

        [Fact]
        public void GetAllItems_ShouldReturnEmptyList_WhenNoItemsInCart()
        {
            var service = new ShoppingCartService();
            var items = service.GetAll();

            Assert.Empty(items);
        }
    }
}