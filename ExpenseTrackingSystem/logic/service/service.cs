using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExpenseTrackeingSystem


{
    public class ExpenseManager
    {
        
        public List<Expenses> expenseslist { get; set; }
        private Data data;

        public ExpenseManager()
        {
            data = new Data();
            expenseslist = data.LoadExpenses();
        }
        public List<Expenses> GetAllExpenses()
        {
            return expenseslist ;
        }


        public void AddExpense(string strName, decimal mAmount, string strCategory, DateTime dtDate)
        {
            Expenses expenses = new Expenses
            {
                Name = strName,
                Expense = mAmount,
                Category = strCategory,
                Date = dtDate       
            };
            expenseslist.Add(expenses);
            data.SaveExpenses(expenseslist);
        }

        public void ViewExpenses()
        {
            foreach (var expense in expenseslist)
            {
                Console.WriteLine($"ExpenseName = {expense.Name} ,Amount = {expense.Expense} , Category ={expense.Category} , Date = {expense.Date}");
            }
        }   

          
      

        public void DeleteExpense( string strname)
        {
            Expenses expense = expenseslist.Find(e =>e.Name.Trim().Equals(strname.Trim(), StringComparison.OrdinalIgnoreCase));
            if (expense != null)
            {
                expenseslist.Remove(expense);
                data.SaveExpenses(expenseslist);
                Console.WriteLine("Deleted Successfully");
               
            }
            else
            {
                Console.WriteLine("Name not Found");
            }
        }


        public decimal TotalExpense()
        {
            decimal totalAmount = 0;

            foreach (var e in expenseslist)
            {
                totalAmount += e.Expense;
            }

            return totalAmount;
        }


    }



}




