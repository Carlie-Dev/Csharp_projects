using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling_Practice
{
    //Inherits from exception
    internal class NumOutOfRangeException : Exception
    {
        //constructors
        public NumOutOfRangeException() { }//Default

        public NumOutOfRangeException(string message) : base(message) 
        { 
            //This runs the matching constructor from the base class
        }



    }
}
