using System;
using System.Collections.Generic;
using System.Text;

namespace _006__Age_API_Practice
{
    internal class Age
    {   //order of variables in API
        public int count { get; set; }
        public string name { get; set; }
        public int? age { get; set; }
        

        //default constructor
        public Age() { }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Count: {count}";
        }
    }
}
