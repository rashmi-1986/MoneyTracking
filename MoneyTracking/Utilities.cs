using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MoneyTracking
{
    internal class Utilities
    {


        private static string directory = @"C:\Users\PRACH\source\repos\MoneyTracking\MoneyTracking\";
        private static string fileName = "Item.txt";
        

        internal static void DisplayExpense()
        {
            string mypath = $"{directory}{fileName}";
            /*Console.WriteLine("Select type of tracking");
            Console.WriteLine("(a). ALL\n (b). EXPENSES\n (c). INCOME\n");
            Console.Write("Your selection: ");*/
            string[] ExpenseLines = (string[])File.ReadAllLines(mypath);
            Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in ExpenseLines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();


        }
        
        
        
        internal static void AddExpense()
        {
            Console.WriteLine("(2) Add new Expenses/Income");

            Console.WriteLine("Press q to show list");
            Console.ReadLine();
            
        }
        
        
        
        
        internal static void EditExpense()
        {

        }
        
        
        
        
        internal static void Save()
        {
            
        }

    }
}