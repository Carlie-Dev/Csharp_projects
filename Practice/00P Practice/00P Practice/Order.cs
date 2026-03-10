using System;
using System.Collections.Generic;
using System.Text;

namespace _00P_Practice
{
    internal class Order
    {
        //Private Properties

        private List<Food> items = new List<Food>();

        public List<Food> Items { get { return items; } set { items = value; } }

        //Methods

        public double Total()
        {
            double total = 0;
            foreach (Food item in Items)
            {
                total += item.Price;
            } 
            return total;
        }
        public void DisplayItems() {
            foreach (Food item in Items)
            {
                Console.WriteLine(item);
            }
        }
    } 
}
