using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern;

public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;
    private readonly ITextbox _textbox;

    public Application(IUiFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
        _textbox = factory.CreateTextBox();
    }

    public void Render()
    {
        _button.Render();
        _checkbox.Render();
        _textbox.Render();
    }
}