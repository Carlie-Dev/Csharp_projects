using System;
using System.Collections.Generic;
using System.Text;

namespace _00P_Practice
{
    internal class BreadStick : Food
    {
        //Private properties
        private bool cheese;

        //Public
        public bool Cheese { get { return cheese; } set { cheese = value; } }

        //constructor
        public BreadStick(bool cheese) {
            this.cheese = cheese;
            if (cheese) {
                this.Name = "Cheesy Breadstick";
                this.Price = 6.99;
            }else
            {
                this.Name = "Breadstick";
                this.Price = 5.99;
            }
        }
    }

}
