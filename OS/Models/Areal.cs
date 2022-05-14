using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace OS;

public class Areal
{
    private static int idstatic = 0;
    public Areal(string name)
    {
        Id = ++idstatic;
        Name = name;
    }
    public Areal(string name, List<int> ids)
    {
        Id = ++idstatic;
        Name = name;
        IdsAnimals = new List<int>();
        ids.ForEach(e =>
        {
            IdsAnimals.Add(e);
        });
    }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    [AllowNull]
    public List<int> IdsAnimals { get; set; }
}