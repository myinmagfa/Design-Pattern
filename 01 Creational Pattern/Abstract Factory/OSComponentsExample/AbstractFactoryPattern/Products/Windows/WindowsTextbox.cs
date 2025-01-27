using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Products.Windows
{
    public class WindowsTextbox:ITextbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows Textbox.");
        }
    }
}
