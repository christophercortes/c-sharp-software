namespace Classes;

// This class keeps record of the genre type in the system.
public class Catalog
{
    private List<string> catalog;
    public Catalog()
    {
        catalog = new List<string> { "Fantasy", "Mystery", "Adventure", "Romance", "Horror", "History"};
    }

    public List<string> GetCatalog()
    {
        return catalog;
    }

}