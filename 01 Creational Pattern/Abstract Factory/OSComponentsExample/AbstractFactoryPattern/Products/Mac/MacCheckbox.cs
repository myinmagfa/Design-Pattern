using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Mac;

public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Mac Checkbox.");
    }
}