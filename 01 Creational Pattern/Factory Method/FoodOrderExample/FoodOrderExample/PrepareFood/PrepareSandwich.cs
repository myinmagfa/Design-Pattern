using FoodOrderExample.Base;
using FoodOrderExample.FoodType;

namespace FoodOrderExample.PrepareFood;

public class PrepareSandwich : Maker
{
    public override IFood FactoryMethod()
    {
        return new Sandwich();
    }
}