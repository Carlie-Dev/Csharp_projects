using System;
using System.Collections.Generic;
using System.Text;

namespace _02__Shopping_Cart
{
    public class Product
    {
        //attributes
        public string name;
        public double price;
        public int quantity;

        //subtotal calculation
        public double Subtotal() {
            double subtotal;
            //convert quantity to double so they can be multiplied
            double _quantity = Convert.ToDouble(quantity);
            return subtotal = this.price * _quantity;
        }
    }
}
