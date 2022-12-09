using Banking_Application_Assignment;
//Account a = new Account();
Banking newacc = new Banking();
BankingTransaction transaction = new BankingTransaction();
BankingOperation operation = new BankingOperation();
string continueExecution = string.Empty;

Console.WriteLine("Welcome to our Bank");
do
{
    Console.WriteLine("Lets create an account!");
    Console.WriteLine("Enter Account Name");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string AccountName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.WriteLine("Enter Opening Balance");
    decimal openBalance = Convert.ToDecimal(Console.ReadLine());
#pragma warning disable CS8604 // Possible null reference argument for parameter 'AccName' in 'void Banking.CreateAccount(string AccName, decimal OpeningBal)'.
    newacc.CreateAccount(AccountName,openBalance);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'AccName' in 'void Banking.CreateAccount(string AccName, decimal OpeningBal)'.
    Console.WriteLine("Do you want to continue?");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    continueExecution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

}while(continueExecution == "y" || continueExecution == "Y");

operation.RandomCall();
