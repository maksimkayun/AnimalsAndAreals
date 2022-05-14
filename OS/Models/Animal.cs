using System.ComponentModel.DataAnnotations;

namespace OS;

public class Animal
{
    private static int idstatic = 0;
    public Animal(string name, string species)
    {
        Id = ++idstatic;
        Name = name;
        Species = species;
    }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
}