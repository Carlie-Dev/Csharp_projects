using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _03__Bank_Accounts
{
    public class Saving : Account
    {
        double interestRate;

        public double InterestRate { get { return interestRate; } set { interestRate = value; } }

        //constructor
        public Saving()
        {

        }
        public void AddInterest()
        {
            balance += (balance * interestRate / 12);
        }
        
    }
}
