namespace GraphicEditor.Base
{
    public class Shapes
    {
        public class Circle : BaseShape
        {
            public int Radius { get; set; }
        }

        public class Rectangle : BaseShape
        {
            public int Width { get; set; }
            public int Height { get; set; }
        }

    }
}
