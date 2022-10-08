using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyTracking;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel;

string options;
do
{

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***************************");
            Console.WriteLine("* Welcome to MoneyTracking *");
            Console.WriteLine("***************************");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pick an option from 1 - 4 : ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("(1) Show Expenses)");
            Console.WriteLine("(2) Add new Expenses");
            Console.WriteLine("(3) Edit Expense");
            Console.WriteLine("(4) Quit");
            Console.Write("Enter the Option: ");
            
            options=Console.ReadLine();
            
            switch (options)
            {
                case "1":
                  Utilities.DisplayExpense();
                    break;
                case "2":
                  Utilities.AddExpense();
                    break;
                case "3":
                  Utilities.EditExpense();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid selection.Please try again");
                    break;
            }
}
while (options != "4");
Console.WriteLine("Thanks for using the application");

/*static void DisplayExpense()
{
    Console.WriteLine("Code to display expense");
    return;
}

static void AddExpense()
{
    Console.WriteLine("Code to add expense");
    return;
}

static void EditExpense()
{
    Console.WriteLine("Code to edit expense");
    return;
}
/* static void ShowItems()
 {


     //List<Items> items = new List<Items>();
     string filepath = @"C:\ExpencesFile1.txt";
     Console.ReadLine();
     Console.WriteLine(" You have selected Option (1).");
     Console.WriteLine("ALL");
     Console.WriteLine("Expenses".PadRight(10) + "Income".PadRight(10));
     Console.ReadLine();
     /*foreach (Items item in items)
      {
         // Console.WriteLine(item.Expenses.PadRight(10) + item.Income.PadRight(10));
      }*/

// Console.ReadLine();

/*class Items : Item
{
    public Items(int expenses, int income)
    {
        Expenses = expenses;
        Income = income;
    }

    public int Expenses { get; set; }
    public int Income { get; set; }
}

}*/

/* static void AddNew()
 {
        Console.WriteLine("(2) Add new Expenses/Income");

        Console.WriteLine("Press q to show list");
        {
            string expenceinput;
            int value = 0;

            while (true)
            {
                Console.Write("Input Expence : ");
                expenceinput = Console.ReadLine();

                {
                    break;
                }


                Console.Write("Input Income : ");
                expenceinput = Console.ReadLine();

                Console.ReadLine();
                Console.WriteLine("Expenses/Income");
            }
        }
 }

    static void EditItem()
    {
        Console.WriteLine("(3) Edit item (edit, remove");
        Console.ReadLine();
    }

    static void Save()
    {
        Console.WriteLine("Press Enter to Save and Quit");
        Console.ReadLine();
        System.Environment.Exit(1);
    }

}
}









/*class Tracking
{
private static string itemType;
string filepath = @"C: ExpencesFile1.txt";

internal static void ShowItems(List<Item> items)

{
Console.WriteLine("Select type of tracking");
Console.WriteLine("(a). ALL\n (b). EXPENSES\n (c). INCOME\n");
Console.Write("Your selection: ");
string itemFilterType = Console.ReadLine();
if (itemType == "(a)" && itemType == "(b)" && itemType == "(c)")
{
    Console.WriteLine("Invalid selection");
    return;
}

}*/











