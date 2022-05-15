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

    public Areal? GetArealById(int id)
    {
        return _areals.FirstOrDefault(e => e.Id == id);
    }

    public Areal? GetArealByName(string name)
    {
        return _areals.FirstOrDefault(e => e.Name.Equals(name));
    }

    public Areal? RemoveArealById(int id)
    {
        var areal = _areals.FirstOrDefault(e => e.Id == id);
        if (areal != default)
        {
            _areals.Remove(areal);
        }

        return areal;
    }

    public Areal AddAreal(Areal areal)
    {
        throw new NotImplementedException();
    }
}