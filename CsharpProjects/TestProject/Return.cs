namespace Classes;

// This class keeps a record of the book to be returned. 
public class Return
{
    public int Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Return(int amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }
}