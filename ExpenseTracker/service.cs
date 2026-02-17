using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExpenseTracker
{
    public class ExpenseManager
    {
        public List<Expenses> ExpensesList { get; set; }
        private Data data;

        public ExpenseManager()
        
        {
            data = new Data();
            ExpensesList = data.LoadExpenses();
        }
        public List<Expenses> GetAllExpenses()
        {
            return ExpensesList;
        }

        public void AddExpense()
        {
            
            Console.Write("Enter Name of the Expense : ");
            string name = Console.ReadLine();

            Console.Write("Enter the Amount: ");
            double expense = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Category: ");
            string category = Console.ReadLine();

            Expenses expenses = new Expenses
            {
                Name = name,
                Expense = expense,
                Category = category
            };
            ExpensesList.Add(expenses);
            data.SaveExpenses(ExpensesList);
            Console.WriteLine("Added successfully!");
        }
        public void ViewExpenses()
        {
            foreach (var expense in ExpensesList)
            {
                Console.WriteLine ($"Name :{expense.Name}, Amount :{expense.Expense}, category :{expense.Category}");
            }
        }

        public void DeleteExpense()
        {
            Console.Write("Enter expense name to delete: ");
            string name = Console.ReadLine();

            Expenses expense = ExpensesList.Find(e => e.Name == name);

            if (expense != null)
            {
                ExpensesList.Remove(expense);
                data.SaveExpenses(ExpensesList);
                Console.WriteLine("Expense deleted.");
            }
            else
            {
                Console.WriteLine("Expense not found.");
            }
        }

   
     
    }

}

