using System;
using System.Collections.Generic;
using System.Text;

namespace _00P_Practice
{
    internal class Pizza : Food
    {
        //Utility Properties
        public static string[] Toppings = { "Pepperoni", "Mushroom", "Olives", "Sausage", "Pineapple" };

        public static string[] Sizes = { "Small", "Medium", "Large", "Extra Large", "Approx Eagle Size" };

        //Private Properties
        private List<string> selToppings = new List<string>();
        private string size;

        //Public Properties
        public List<string> SelToppings {  get { return selToppings; } set { selToppings = value; } }
        public string Size { get { return size; } 
            set {
                if (Sizes.Contains(value))
                {
                    size = value;
                }
                else 
                {
                    throw new ArgumentException("Not a valid size");
                }
            }
        }

        //Constructors
        public Pizza(List<string> _toppings, string _size) 
        { 
            this.SelToppings = _toppings;
            this.Size = _size;
            this.Name = $"{size} - {SelToppings.Count} Toppings";
            //wacky way to get size pricing
            this.Price = 5 + (SelToppings.Count) + (Array.IndexOf(Sizes, size) * 2);
        }
    }
}
