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

    public Animal GetAnimalById(int id)
    {
        throw new NotImplementedException();
    }

    public Animal GetAnimalByName(string Name)
    {
        throw new NotImplementedException();
    }

    public Animal RemoveAnimalById(int id)
    {
        throw new NotImplementedException();
    }

    public Animal AddAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }
}