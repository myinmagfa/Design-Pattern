namespace GraphicEditor.Base
{
    public class Shapes
    {
        public class Circle : BaseShape
        {
            public int Radios { get; set; }
            public override IShapePrototype Clone()
            {
                return (Circle)MemberwiseClone();
            }
        }

        public class Rectangle : BaseShape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public override IShapePrototype Clone()
            {
                return (Rectangle)MemberwiseClone();
            }
        }

    }
}
