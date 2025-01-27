using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Mac;

public class MacTextbox:ITextbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Mac Textbox.");
    }
}