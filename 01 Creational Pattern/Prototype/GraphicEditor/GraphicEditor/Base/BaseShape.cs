namespace GraphicEditor.Base
{
    public class BaseShape : IShapePrototype
    {
        public string Color { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        
        public BaseShape ShallowCopy()
        {
            return (BaseShape)MemberwiseClone();
        }

    }
}
