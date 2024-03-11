namespace Animals.Models;

public abstract class Animal
{
    protected string name;
    protected string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.name = name;
        this.favouriteFood = favouriteFood;
    }

    public abstract string ExplainSelf();
}
