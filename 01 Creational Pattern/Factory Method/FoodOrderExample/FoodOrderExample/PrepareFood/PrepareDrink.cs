using FoodOrderExample.Base;
using FoodOrderExample.FoodType;

namespace FoodOrderExample.PrepareFood;

public class PrepareDrink : Maker
{
    public override IFood FactoryMethod()
    {
        return new Drink();
    }
}