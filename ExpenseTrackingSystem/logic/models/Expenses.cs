using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace ExpenseTrackeingSystem
{
        public class Expenses
        {
        public Expenses()
        {
            Name = string.Empty;
            Expense = 0.00m;
            Category = string.Empty;
            Date = DateTime.Now;
        }
        public string Name { get; set; }
        public decimal Expense { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        
    }

       
    }

