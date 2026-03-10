using System;
using System.Collections.Generic;
using System.Text;

namespace _04__Budget_App
{
    public class OverBudgetException : Exception
    {
        //default constructor
        public OverBudgetException() { }

        public OverBudgetException(string message) : base (message) {}
        
    }
}
