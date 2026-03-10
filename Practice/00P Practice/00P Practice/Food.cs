using System;
using System.Collections.Generic;
using System.Text;

namespace _00P_Practice
{
    internal abstract class Food //can't be instantiated
    {
        //Private Properties
        private string name;
        private double price;
        private int inventory = 0;

        //Public Properties
        public string Name {  get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int Inventory { get { return inventory; } set { inventory = value; } }

        //Methods
        public override string ToString()
        {
            return $"{name} - ${price}";
        }

        public void UpdateInventory(int amount)
        {
            this.inventory += amount;
        }
    }
}
