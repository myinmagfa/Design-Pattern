using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Windows;

public class WindowsFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }

    public ITextbox CreateTextBox()
    {
        return new WindowsTextbox();
    }
}