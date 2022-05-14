namespace OS.Data;

public interface IArealStorage
{
    public IEnumerable<Areal> GetAllAreals();
    public Areal GetArealById(int id);
    public Areal GetArealByName(string Name);
    public Areal RemoveArealById(int id);
    public Areal AddAreal(Areal Areal);
}