using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _03__Bank_Accounts
{
    public class Transaction
    {
        //attributes of the transaction
        bool credit;
        double amount;
        string description;
        DateTime date;

        //public accessors
        public bool Credit { get { return credit; } set { credit = value; } }
        public double Amount { get { return amount; } set { amount = value; } }
        public string Description { get { return description; } set { description = value; } }
        public DateTime Date { get { return date; } set { date = value; } }

        //Default constructor
        public Transaction()
        {

        }

    }
}
