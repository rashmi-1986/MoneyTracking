using MoneyTracking;
//using System.Transactions;



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

