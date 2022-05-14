namespace OS.Data;

public class ArealStorage : IArealStorage
{
    private List<Areal> _areals;

    public ArealStorage()
    {
        _areals = new List<Areal>()
        {
            new Areal("Австралия", new List<int>(){1, 2, 3}),
            new Areal("Азия", new List<int>(){4})
        };
    }

    public IEnumerable<Areal> GetAllAreals()
    {
        return _areals.Select(e => e).ToList();
    }

    public Areal GetArealById(int id)
    {
        throw new NotImplementedException();
    }

    public Areal GetArealByName(string Name)
    {
        throw new NotImplementedException();
    }

    public Areal RemoveArealById(int id)
    {
        throw new NotImplementedException();
    }

    public Areal AddAreal(Areal Areal)
    {
        throw new NotImplementedException();
    }
}