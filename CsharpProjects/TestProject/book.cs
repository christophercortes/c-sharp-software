namespace Classes;

// This class keeps record of the books in the library system.
public class Books
{
    private List<string> fantasyBooks;
    private List<string> mysteryBooks;
    private List<string> adventureBooks;
    private List<string> romanceBooks;
    private List<string> horrorBooks;
    private List<string> historyBooks;
    public Books()
    {
        fantasyBooks = new List<string> { "The Night Circus", "The Name of the Wind", "Good Omens" };
        mysteryBooks = new List<string> { "The Big Sleep", "The Name of the Rose", "Gone Girl" };
        adventureBooks = new List<string> { "Treasure Island", "Into the Wind", "The Count of Monte Cristo" };
        romanceBooks = new List<string> { "The Bride Test", "Outlander", "Dark Lover" };
        horrorBooks = new List<string> { "The Haunting of Hill House", "It", "Salem's Lot" };
        historyBooks = new List<string> { "The Guns of August", "The Devil in the White City", "1776" };


        fantasyBooks.Sort();
        mysteryBooks.Sort();
        adventureBooks.Sort();
        romanceBooks.Sort();
        horrorBooks.Sort();
        historyBooks.Sort();
    }
    public List<string> GetFantasy() => fantasyBooks;
    public List<string> GetMystery() => mysteryBooks;
    public List<string> GetAdventure() => adventureBooks;
    public List<string> GetRomance() => romanceBooks;
    public List<string> GetHorror() => horrorBooks;
    public List<string> GetHistory() => historyBooks;
}