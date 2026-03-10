using System;
using System.Collections.Generic;
using System.Text;

namespace API_Practice
{
    internal class Fact
    {
        public Data[] data { get; set; }

        //Methods
        public override string ToString()
        {
            string output = "";
            //getting output
            foreach (Data fact in data) {
                output += fact.ToString(); //Append a fact to the string
                output += "\n"; //add a new line to the facts
            }

            return output;
        }

    }

    internal class Data
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attribute attributes {  get; set; }

        //Methods

        public override string ToString()
        {
            return $"{attributes.body}";
        }
    }

    internal class Attribute 
    {
        //Properties
        public string body { get; set; }
    }
}
