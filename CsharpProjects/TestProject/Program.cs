using System.Reflection.Metadata;
using Classes;

Console.WriteLine($"\n||:. Welcome to the Library Catalog System .:||\n");

Catalog myCatalog = new Catalog();
List<string> catalogList = myCatalog.GetCatalog();

Console.WriteLine("Our genre collection is:\n");

foreach (string item in catalogList)
{
    Console.Write($" {item} |");
}

Console.WriteLine("\n");

Books myBooks = new Books();

Console.WriteLine("Fantasy:\n");
List<string> fantasy = myBooks.GetFantasy();

foreach (var f in fantasy)
{
    Console.Write($" {f},");
}

Console.WriteLine("\n");

Console.WriteLine("Mystery:\n");
List<string> mystery = myBooks.GetMystery();

foreach (var m in mystery)
{
    Console.Write($" {m},");
}

Console.WriteLine("\n");

Console.WriteLine("Adventure:\n");
List<string> adventure = myBooks.GetAdventure();

foreach (var a in adventure)
{
    Console.Write($" {a},");
}

Console.WriteLine("\n");

Console.WriteLine("Romance:\n");
List<string> romance = myBooks.GetRomance();

foreach (var r in romance)
{
    Console.Write($" {r},");
}

Console.WriteLine("\n");

Console.WriteLine("Horror:\n");
List<string> horror = myBooks.GetHorror();

foreach (var h in horror)
{
    Console.Write($" {h},");
}

Console.WriteLine("\n");

Console.WriteLine("History:\n");
List<string> history = myBooks.GetHistory();

foreach (var h in history)
{
    Console.Write($" {h},");
}

Console.WriteLine("\n");

Console.WriteLine("-------------------------------------------\n");
Console.WriteLine("What's your name?");
string? userName = Console.ReadLine()?.Trim().ToLower();

var account = new LibraryCatalogSystem($"{userName}", 10);
Console.WriteLine($"{account.User} your ID number is {account.Number} and you have {account.Loan} initial Loans.\n");
Console.WriteLine("-------------------------------------------");

Console.WriteLine("Do you want to request (1) or return a book (2) or view account history (3)?");
string? answer = Console.ReadLine()?.Trim().ToLower();

switch (answer)
{
    case "1":
        Console.WriteLine("Enter the number of books to request:");
#pragma warning disable CS8604 // Possible null reference argument.
        int requestAmount = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
        account.RequestBooks(requestAmount, DateTime.Now, "User requested books");
        break;
    case "2":
        Console.WriteLine("Enter the number of books to return:");
#pragma warning disable CS8604 // Possible null reference argument.
        int returnAmount = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
        account.ReturnBooks(returnAmount, DateTime.Now, "User returned books");
        break;
    case "3":
        Console.WriteLine(account.GetAccountHistory());
        break;
    default:
        Console.WriteLine("Invalid choice. Exiting.");
        break;
}

try
{
    var invalidAccount = new LibraryCatalogSystem("invalid", 10);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
}

try 
{
    account.RequestBooks(7, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}