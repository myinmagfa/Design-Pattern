using FoodOrderExample.Base;
using FoodOrderExample.PrepareFood;

namespace FoodOrderExample;

internal class Program
{
    private static void Main(string[] args)
    {
        new Client().Main();
    }
}

internal class Client
{
    public void Main()
    {
        CreateHandler(new PreparePizza());
        CreateHandler(new PrepareSandwich());
        CreateHandler(new PrepareDrink());
    }

    public void CreateHandler(Maker maker)
    {
        maker.MakeFood();
        Console.WriteLine();
    }
}