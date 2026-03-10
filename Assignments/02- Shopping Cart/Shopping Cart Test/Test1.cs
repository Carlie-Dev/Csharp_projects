using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using _02__Shopping_Cart;

namespace Shopping_Cart_Test
{
    [TestClass]
    public sealed class Test1
    {

        private ShoppingCart _shoppingCart;
       

        [TestInitialize]
        public void Setup()
        {
            //added two basic products with no negative values
            Product product1 = new Product();
            product1.name = "Test1";
            product1.price = 100;
            product1.quantity = 3;

            Product product2 = new Product();
            product2.name = "Test2";
            product2.price = 10;
            product2.quantity = 4;

            _shoppingCart = new ShoppingCart();
            _shoppingCart.Cart.Add(product1);
            _shoppingCart.Cart.Add(product2);
        }

        [TestMethod]
        public void Total_ShouldReturnDouble() {
            //Result to get back
            var result = _shoppingCart.Total();
            //Assert
            Assert.AreEqual(340,result);
        }

        [TestMethod]
        public void Total_ShouldIgnoreNegativePrice() {
            //add the two new items
            Product temp = new Product();
            Product temp2 = new Product();
            temp.name = "Hat";
            temp.price = -2;
            temp.quantity = 3;
            temp2.name = "Scarf";
            temp2.price = -3;
            temp2.quantity = 4;
            //Add list of products


            _shoppingCart.Cart.Add(temp);
            _shoppingCart.Cart.Add(temp2);
            
            var result = _shoppingCart.Total();
            Assert.AreEqual(340, result);
        }

        [TestMethod]

        public void Total_ShouldIgnoreNegativeQuantity()
        {
            //add the two new items
            Product temp = new Product();
            Product temp2 = new Product();
            temp.name = "Hat";
            temp.price = 2;
            temp.quantity = -3;
            temp2.name = "Scarf";
            temp2.price = 3;
            temp2.quantity = -4;
            //Add list of products


            _shoppingCart.Cart.Add(temp);
            _shoppingCart.Cart.Add(temp2);


            var result = _shoppingCart.Total();
            Assert.AreEqual(340, result);

        }
    }
}
