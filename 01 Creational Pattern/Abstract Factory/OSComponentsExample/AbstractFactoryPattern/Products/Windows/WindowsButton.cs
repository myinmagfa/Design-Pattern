using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Windows;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows Button.");
    }
}