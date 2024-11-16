namespace Classes;

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