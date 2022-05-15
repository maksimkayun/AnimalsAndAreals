namespace OS.Data;

public class AnimalStorage : IAnimalStorage
{
    private List<Animal> _animals;
    private readonly IArealStorage _arealStorage;
    public AnimalStorage(IArealStorage arealStorage)
    {
        _arealStorage = arealStorage;
        _animals = new List<Animal>()
        {
            new Animal("Австралийский чеглок", "Хищная птица"),
            new Animal("Австралийский ложный вампир", "Рукокрылые"),
            new Animal("Австралийский бычерыл", "Хрящевая рыба"),
            new Animal("Азиатский кеклик", "Птица")
        };
    }

    public IEnumerable<Animal> GetAllAnimals()
    {
        return _animals.Select(e => e).ToList();
    }

    public Animal? GetAnimalById(int id)
    {
        return _animals.FirstOrDefault(e => e.Id == id);
    }

    public Animal? GetAnimalByName(string name)
    {
        return _animals.FirstOrDefault(e => e.Name.Equals(name));
    }

    public Animal? RemoveAnimalById(int id)
    {
        var animal = _animals.FirstOrDefault(e => e.Id == id);
        if (animal != default)
        {
            _animals.Remove(animal);
        }
        return animal;
    }

    public Animal AddAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }
}