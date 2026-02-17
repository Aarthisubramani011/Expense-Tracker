using System;
namespace ExpenseTrackeingSystem

{

    public class ExpenseReviewer
    {
        private ExpenseManager expenseManager = new ExpenseManager();


        public void Initalize()
        {
            Console.WriteLine("Expense Tracker!");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expense");
            Console.WriteLine("3. Delete Expense");
            Console.WriteLine("4. Total Expense");
            Console.WriteLine("5.Exit");


            while (true)
            {
                Console.Write("\nEnter your choice:");
                int naction = Convert.ToInt32(Console.ReadLine());

                switch (naction)
                {
                    case 1:
                       AddExpense();

                        break;
                    case 2:
                        DisplayExpense();
                        break;

                    case 3:
                        DeleteExpense();
                        break;
                    case 4:
                        TotalExpense();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid action. Please try again.");
                        break;

                }
            }
        }


        public void AddExpense()
        {
            
            Console.WriteLine("Enter expense details:");
            Console.Write("Name:");
            string strName = Console.ReadLine();

            Console.Write("Amount:");
            decimal mAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Category:");
            string strCategory = Console.ReadLine();

            DateTime dtDate = DateTime.Now;
            expenseManager.AddExpense( strName, mAmount, strCategory, dtDate);
            Console.WriteLine("Expense added successfully!");
        }



        public void DisplayExpense()
        {
            expenseManager.ViewExpenses();
        }

        public void DeleteExpense()
        {
            Console.Write("Enter expense name to delete: ");
            string strname = Console.ReadLine();

            expenseManager.DeleteExpense(strname);

        }
        public void TotalExpense()
        {
            decimal mtotal = expenseManager.TotalExpense();
            Console.WriteLine($"TotalExpenses {mtotal}");
        }


    }
}