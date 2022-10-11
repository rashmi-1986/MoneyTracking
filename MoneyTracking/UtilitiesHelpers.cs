using System.Text;
using System.Transactions;

namespace MoneyTracking
{
    internal static class UtilitiesHelpers
    {

        internal static void AddNew(List<Transaction> transactions)
        {
            string mypath = $"{directory}{fileName}";
            //string[] ExpenseLines = (string[])File.ReadAllLines(mypath);
            Console.WriteLine("Adding a new transaction...");

            Console.Write("Input Title: ");
            string title = Console.ReadLine();

            Console.Write("Input Month: ");
            string month = Console.ReadLine();

            Console.Write("Input Amount: ");
            int amount = Console.ReadLine();

            transactions.Add(transaction);

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
    }
}