
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Transactions;
using System.ComponentModel.DataAnnotations;

namespace MoneyTracking
{
    internal class Transaction
    {


        public Transaction(string title, string month, int amount)
        {
            Title = title;
            Month = month;
            Amount = amount;
        }
        public string Title { get; set; }
        public string Month { get; set; }
        public int Amount { get; set; }
    }
    internal class Utilities
    {

        private static List<Transaction> transactions = new List<Transaction>();
        private static string directory = @"C:\Users\PRACH\source\repos\MoneyTracking\MoneyTracking\";
        private static string fileName = "Item.txt";
        private static int edit;
        private static int item;

        internal static void ShowItems()
        {
            string mypath = $"{directory}{fileName}";
            //Console.WriteLine("Select type of tracking");
            //Console.WriteLine("(a). ALL\n (b). EXPENSES\n (c). INCOME\n");
            //Console.Write("Your selection: ");
            string[] ExpenseLines = (string[])File.ReadAllLines(mypath);
            //Console.WriteLine("Money Transaction ");
            
            
            foreach (string line in ExpenseLines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        internal static void AddNew()
        {
            string mypath = $"{directory}{fileName}";
            string[] ExpenseLines = (string[])File.ReadAllLines(mypath);
            Console.WriteLine("Adding a new transaction...");
            string[] UtilitiesAsString = (string[])File.ReadAllLines(mypath);
            for (int i = 0; i < UtilitiesAsString.Length; i++)
            {
                string[] UtilitiesSplit = UtilitiesAsString[i].Split(';');
                string Title = UtilitiesSplit[0].Substring(i + 1);
                string Month = UtilitiesSplit[0].Substring(i + 1);
                string Amount = UtilitiesSplit[0].Substring(i + 1);
            }

                Console.Write("Input Title: ");
            string title = Console.ReadLine();

            Console.Write("Input Month: ");
            string month = Console.ReadLine();

            Console.Write("Input Amount: ");
            int amount = int.Parse(Console.ReadLine());

            transactions.Add(new Transaction(title, month, amount));

            StringBuilder sb = new StringBuilder();
            foreach (Transaction transaction in transactions)
            {
                sb.Append($"Title:{transaction.Title};");
                sb.Append($"Month:{transaction.Month};");
                sb.Append($"Amount:{transaction.Amount};");

                
                sb.Append(Environment.NewLine);
            }
            File.WriteAllText(mypath, sb.ToString());
            Console.WriteLine("Transaction added successfully....");

        }

        internal static void EditItem()
        {
            //Console.Write("Input Title: ");
            //string title = Console.ReadLine();

            //Console.Write("Input Month: ");
            //string month = Console.ReadLine();

            //Console.Write("Input Amount: ");
            //int amount = int.Parse(Console.ReadLine());
           
            //transactions.Add(new Transaction(title, month, amount));

            string mypath = $"{directory}{fileName}";
            string[] ExpenseLines = (string[])File.ReadAllLines(mypath);
            Console.WriteLine("Edit the Transaction...");
            
            
            Console.ReadLine(); 
        }

       

        internal static void Save()
        {
            
            Console.WriteLine("Press Enter Save and Quit the app");
            Console.ReadLine();
        }
    }
}