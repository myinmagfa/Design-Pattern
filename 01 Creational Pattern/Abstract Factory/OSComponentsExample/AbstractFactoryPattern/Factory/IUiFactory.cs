namespace AbstractFactoryPattern.Factory;

public interface IUiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
    ITextbox CreateTextBox();
}