using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace _03__Bank_Accounts
{
    public abstract class Account
    {
        //atributes
        public string accountNumber;
        public string holderFirstName;
        public string holderLastName;
        public double balance;
        public List<Transaction> transactions;

        public virtual void AddTransaction(Transaction transaction)
        {
            //will be overriden
            if(transaction.Credit == true)
            {
                //add to balance
                this.balance += transaction.Amount;
            }else
            {
                //subtract from balance
                this.balance -= transaction.Amount;
            }
        }
    }
}
