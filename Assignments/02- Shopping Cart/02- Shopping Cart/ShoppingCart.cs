using System;
using System.Collections.Generic;
using System.Text;

namespace _02__Shopping_Cart
{
    public class ShoppingCart
    {
        private List<Product> cart = new List<Product> { };

        
        //Public constructor
        public List<Product> Cart {  get { return cart; } set { cart = value; } }
        public ShoppingCart() { 
            Cart = new List<Product>();
        }

        // Total function
        public double Total()
        {
            double total = 0;
            
            foreach (Product item in cart) {
                if (item.price > 0 && item.quantity > 0)
                {
                    total += item.Subtotal();
                }
            }

            return total;
        }
    }
}
