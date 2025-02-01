using GraphicEditor;
using GraphicEditor.Base;
using static GraphicEditor.Base.Shapes;

class program
{
    static void Main()
    {
        var sh = new ShapeManager();
        sh.AddShape("Circle", new Circle { x = 10, y = 20, Color = "Red", Radios = 5 });
        sh.AddShape("Rectangle", new Rectangle { x = 30, y = 40, Color = "Yellow", Width = 100, Height = 50 });
        IShapePrototype cloneCircle = sh.GetShape("Circle");
        IShapePrototype cloneRectangle = sh.GetShape("Rectangle");

        Console.WriteLine($"Circle Cloned with this params: Color= {((Circle)cloneCircle).Color}, Radius= {((Circle)cloneCircle).Radios}");
        Console.WriteLine($"Rectangle Cloned with this params: Color= {((Rectangle)cloneRectangle).Color}, width= {((Rectangle)cloneRectangle).Width}, Height= {((Rectangle)cloneRectangle).Height}");
    }
}