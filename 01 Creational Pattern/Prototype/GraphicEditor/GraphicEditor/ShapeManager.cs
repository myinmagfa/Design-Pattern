using GraphicEditor.Base;

namespace GraphicEditor
{
    public class ShapeManager
    {
        private Dictionary<string, IShapePrototype> shapes = new Dictionary<string, IShapePrototype>();
        public void AddShape(string key,IShapePrototype shape)
        {
            shapes[key] = shape;
        }

        public IShapePrototype GetShape(string key)
        {
            if (shapes.ContainsKey(key))
                return shapes[key].Clone();
            return null;
        }
    }
}
