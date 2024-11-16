using System;
using System.Collections.Generic;
using System.Text;

namespace Classes;

public class LibraryCatalogSystem
{
    public string Number { get; }
    public string User { get; set; }
    public int Loan
    {
        get
        {
            int loan = 0;
            foreach (var item in _allReturn)
            {
                loan += item.Amount;
            }

            return loan;
        }
    }

    // Retrieve account number 
    private static int s_userAccount = 1234567890;
    private List<Return> _allReturn;
    public LibraryCatalogSystem(string name, int initialLoan)
    {
        if (initialLoan < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialLoan), "Initial loan must be non-negative"); 
        }

        Number = s_userAccount.ToString();
        s_userAccount++;

        User = name;
        _allReturn = new List<Return>();
        ReturnBooks(initialLoan, DateTime.Now, "Library System");
    }

    // Request a new book only if it is less than 10.

    public void RequestBooks(int amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "You must request at least one book.");
        }
        if (Loan - amount < 0)
        {
            throw new InvalidOperationException("You cannot request more books than available.");
        }
        var request = new Return(-amount, date, note);
        _allReturn.Add(request);
    }

    // Return books to the library.
    public void ReturnBooks(int amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "You don't have any book to return.");
        }
        if (Loan + amount > 10)
        {
            throw new ArgumentException("You cannot return more books than the inital loans.");
        }
       
        var returnLoans = new Return(amount, date, note);
        _allReturn.Add(returnLoans);
    }

    public string GetAccountHistory()
    {
        var report = new StringBuilder();
        int currentloan = 0;
        report.AppendLine("Date\t\tAmount\tCurrent\tType\tNote");

        foreach(var item in _allReturn)
        {
            currentloan += item.Amount;
            string type = item.Amount > 0 ? "Return" : "Request";
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{currentloan}\t{type}\t{item.Notes}"); 
        }

        return report.ToString();
    }  
}