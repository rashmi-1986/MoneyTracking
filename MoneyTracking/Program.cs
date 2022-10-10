using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyTracking;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel;
using System.Transactions;


List<Transaction> transactions = new List<Transaction>();
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
            Console.WriteLine("(1) Show items (All/Expenses/Income)");
            Console.WriteLine("(2) Add new Expenses/Income");
            Console.WriteLine("(3) Edit Item (edit, remove");
            Console.WriteLine("(4) Save and Quit");
            Console.Write("Enter the Option: ");
            
            options=Console.ReadLine();
            
            switch (options)
            {
                case "1":
                  Utilities.ShowItems();
                    break;
                case "2":
                  Utilities.AddNew();
                    break;
                case "3":
                  Utilities.EditItem();
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




              

    /*

    static void Save()
    {
        Console.WriteLine("Press Enter to Save and Quit");
        Console.ReadLine();
        System.Environment.Exit(1);
    }


*/









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











