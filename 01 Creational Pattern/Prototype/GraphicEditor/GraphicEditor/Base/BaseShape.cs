namespace GraphicEditor.Base
{
    public abstract class BaseShape : IShapePrototype
    {
        public string Color { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public abstract IShapePrototype Clone();

    }
}
