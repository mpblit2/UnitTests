using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ShoppingCart;

namespace ShoppingCartTests
{
    [TestFixture]
    class CartTests
    {
        private Cart _cart;
        private CartItem _item;
        private CartItem _item2;
        
        [SetUp]
        public void SetUp()
        {
            _cart = new Cart();
            _item = new CartItem(2, "Test", 1.00m);
            _item2 = new CartItem(3, "Test2", 2.00m);
        }
        [Test]
        public void CartCanContainZeroItem()
        {
            Assert.That(_cart.Items.Count, Is.EqualTo(0));
        }

        [Test]
        public void CartCanAddItem()
        {
            _cart.AddItem(_item);

            Assert.That(_cart.Items, Has.Member(_item));
        }

        [Test]
        public void CartContainsNoDuplicateItems()
        {
            _cart.AddItem(_item);
            _cart.AddItem(_item);

            Assert.That(_cart.Items.Count, Is.EqualTo(1));
        }

        [Test]
        public void CartCanRemoveItem()
        {
            _cart.AddItem(_item);
            _cart.RemoveItem(_item);

            Assert.That(_cart.Items.Count, Is.EqualTo(0));
        }

        [Test]
        public void TotalEqualsSumOfItemPrices()
        {
            _cart.AddItem(_item);
            _cart.AddItem(_item2);

            var actual = _cart.GetCartTotal();

            Assert.That(actual, Is.EqualTo(8.00m));
        }
    }
}
