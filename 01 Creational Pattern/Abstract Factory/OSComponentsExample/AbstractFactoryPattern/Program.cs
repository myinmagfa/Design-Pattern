using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Products.Linux;
using AbstractFactoryPattern.Products.Mac;
using AbstractFactoryPattern.Products.Windows;

namespace AbstractFactoryPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Select Operation System:\n 1 - Windows\n 2 - Mac\n 3 - Linux\n");
        var choice = Console.ReadLine();

        IUiFactory factory = choice switch
        {
            "1" => new WindowsFactory(),
            "2" => new MacFactory(),
            "3"=>new LinuxFactory(),
            _ => throw new ArgumentException()
        };

        var application = new Application(factory);
        application.Render();
    }
}