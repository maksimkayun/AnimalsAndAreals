namespace OS.Data;

public interface IAnimalStorage
{
    public IEnumerable<Animal> GetAllAnimals();
    public Animal? GetAnimalById(int id);
    public Animal? GetAnimalByName(string name);
    public Animal? RemoveAnimalById(int id);
    public Animal AddAnimal(Animal animal);
}