using System;
using System.Collections.Generic;
using System.Text;

namespace _00P_Practice
{
    internal class Salad : Food
    {
        //Utilizing Properties
        public static string[] saladOptions = { "Ceaser", "Greek", "Garden"};

        //Constructors
        public Salad(string type) { 
            this.Name = type;
            if (type == "Ceaser")
            {
                this.Name = type;
                this.Price = 6.99;
            }else if (type == "Greek" || type == "Garden") { 
                this.Name = type;
                this.Price = 5.99;
            }
        }

    }
}
