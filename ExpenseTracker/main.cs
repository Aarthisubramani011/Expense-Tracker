using System.Xml.Linq;

namespace ExpenseTracker
{
    public class main
    {
        public static void Main()
        {

            Expenses expenses = new Expenses();

            ExpenseManager expenseManager = new ExpenseManager();

            Console.WriteLine("Expense Tracker!");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expense");
            Console.WriteLine("3. Delete Expense");
            Console.WriteLine("4. Exit");


            while(true){
                int action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        expenseManager.AddExpense();
                        break;
                    case 2:
                        expenseManager.ViewExpenses();
                        break;
                   
                    case 3:
                        expenseManager.DeleteExpense();
                        break;
                    case 4:
                        return;

                }

              

            }







        }
    }
}

