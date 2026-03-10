using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _03__Bank_Accounts
{
    public class Checking : Account
    {
        //constructor
        public Checking() { }
        public override void AddTransaction(Transaction transaction)
        {
            if (transaction.Credit == false)
            {
                //adding charge
                base.AddTransaction(transaction);
                if (balance <= 0) { 
                    //create new
                    Transaction overDraft = new Transaction();
                    overDraft.Credit = false;
                    overDraft.Amount = 10;
                    overDraft.Description = "Overdraft Fee";
                    overDraft.Date = DateTime.Now;
                    //adding overdraft charge
                    base.AddTransaction(overDraft);
                }
            }
            else
            {
                //run as normal
                base.AddTransaction(transaction);
            }
        }
    }
}
