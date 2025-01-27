using FoodOrderExample.Base;
using FoodOrderExample.FoodType;

namespace FoodOrderExample.PrepareFood;

public class PreparePizza : Maker
{
    public override IFood FactoryMethod()
    {
        return new Pizza();
    }
}