using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Transactions;

namespace MoneyTracking
{
    internal class Utilities
    {


        private static string directory = @"C:\Users\PRACH\source\repos\MoneyTracking\MoneyTracking\";
        private static string fileName = "Item.txt";
        private static object transaction;
        private static object extraTransaction;
        private static object transaction1;
        private static object x;
        private static List<byte> listValue;

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
            Console.WriteLine();
            {

                
                List<Transaction> transactions = new List<Transaction>();
                //List<byte> values = (List<byte>)listValue;
                

                  while (true)
                {
                    Console.Write("Input Title: ");
                    string titleInput = Console.ReadLine();
                    if (titleInput.ToLower().Trim() == "q")
                    {
                        break;
                    }

                    Console.Write("Input Month: ");
                    string monthInput = Console.ReadLine();
                    if (monthInput.ToLower().Trim() == "q")
                    {
                        break;
                    }

                    string amountInput;
                    int value = 0;
                    while (true)
                    {
                        Console.Write("Input Amount: ");
                        amountInput = Console.ReadLine();

                        if (amountInput.ToLower().Trim() == "q")
                        {
                            break;
                        }

                        bool isValue = int.TryParse(amountInput, out value);
                        if (!isValue)
                        {
                            Console.WriteLine("Incorrect amount!");
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (amountInput.ToLower().Trim() == "q")
                    {
                        break;
                    }

                    Transaction transaction = new Transaction(titleInput, monthInput, value);
                    transactions.Add(transaction);

                }
                List<Transaction> sortedTransactions = transactions.OrderBy(transaction => transaction.Expense).ToList();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Title".PadRight(20) + "Month".PadRight(20) + "Amount");
                
                
                foreach (Transaction transaction in sortedTransactions)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(transaction.Title.PadRight(20) + transaction.Month.PadRight(20) + transaction.Expense);
                }

                //int sum = transactions.Sum(transaction => transaction.Expense);
                //Console.WriteLine("Sum: ".PadRight(40) + sum);

                Console.WriteLine("");
                Console.WriteLine("Press q + Enter to exit or just press Enter to add more items");
                string decision = Console.ReadLine();
                if (decision.ToLower().Trim() == "q")
                {
                    //break;
                }

            }
            Console.ReadLine();
        }

        class Transaction : Utilities
        {
            internal Transaction next;

            public Transaction()
            {
            }

            public Transaction(string title, string month, int amount)
            {
                Title = title;
                Month = month;
                Expense = amount;
            }
            public string Title { get; set; }
            public string Month { get; set; }

            public int Expense { get; set; }
            public object Salary { get; internal set; }
        }


        internal static void EditItem()
        {

        }




        internal static void Save()
        {
            Console.WriteLine("Press Enter Save and Quit the app");

        }
    }
}