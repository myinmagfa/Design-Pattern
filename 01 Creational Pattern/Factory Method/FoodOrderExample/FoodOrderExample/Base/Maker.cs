namespace FoodOrderExample.Base;

public abstract class Maker
{
    public abstract IFood FactoryMethod();

    public void MakeFood()
    {
        var food = FactoryMethod();
        food.Serve();
    }
}