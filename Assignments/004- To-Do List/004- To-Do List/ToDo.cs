using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _004__To_Do_List
{
    internal class ToDo
    {
        private string desc;
        private string dueDate;
        private bool complete;

        public string Description { get { return desc; } set { desc = value; } }
        public string DueDate { get { return dueDate; } set { dueDate = value; } }
        public bool Complete { get { return complete; } set { complete = value; }  }
        
        // default constructor
        public ToDo() { }

        //specific constructor
        public ToDo(string _desc, string _dueDate) {
            this .desc = _desc;
            this .dueDate = _dueDate;
            //default completion is false
            this .complete = false;
        }
        public void MarkComple()
        {
            this.complete = true; 
        }

        public override string ToString()
        {
            string checkmark = "N";
            if (complete == true) {
                checkmark = "C";
            }
            return $"[{checkmark}] {desc} -- {dueDate}";
        }
    }
}
