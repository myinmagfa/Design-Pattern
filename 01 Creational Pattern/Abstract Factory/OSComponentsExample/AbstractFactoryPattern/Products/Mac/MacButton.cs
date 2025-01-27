using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Mac;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Mac Button.");
    }
}