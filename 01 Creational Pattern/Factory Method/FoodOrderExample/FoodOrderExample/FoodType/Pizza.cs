using FoodOrderExample.Base;

namespace FoodOrderExample.FoodType;

public class Pizza : IFood
{
    public void Serve()
    {
        Console.WriteLine("Served Pizza.");
    }
}