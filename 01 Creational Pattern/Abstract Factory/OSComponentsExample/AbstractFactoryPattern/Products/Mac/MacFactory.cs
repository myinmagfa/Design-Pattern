using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Mac;

public class MacFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }

    public ITextbox CreateTextBox()
    {
        return new MacTextbox();
    }

}