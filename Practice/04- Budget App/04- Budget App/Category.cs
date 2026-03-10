using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace _04__Budget_App
{
    public class Category
    {
        //properties
        public string description;
        public double limit;
        public List<Expense> expenses = new List<Expense>();

        //List accessor
        //public List<Expense> Expenses
        //{
        //    get { return expenses; }
        //    set { expenses = value; }
        //}

        //Methods
        public double Total()
        {
            double total = 0;

            //loop through the list of expenses for this category and add the amount of each expense to the total
            foreach (Expense expense in expenses)
            {
                total = total + expense.amount;
            }
            //return the total of the expenses in this category
            return total;
        }

        public void AddExpense(Expense expense) {
            double total = this.Total(); //get the total of the expenses in this category
            if ((total + expense.amount) >= this.limit) //if the total of the expenses in this category plus the amount of the new expense is greater than or equal to the limit for this category, throw an exception
            {
                throw new OverBudgetException("The amount you entered puts this category over budget, please enter a different value.");
            }
            else //if the total of the expenses in this category plus the amount of the new expense is less than the limit for this category, add the new expense to the list of expenses for this category
            {
                expenses.Add(expense);
            }
            
        }
    }
}
