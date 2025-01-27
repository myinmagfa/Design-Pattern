using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Windows;

public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows Checkbox.");
    }
}