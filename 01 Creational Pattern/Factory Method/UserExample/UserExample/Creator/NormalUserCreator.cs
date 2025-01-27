using UserExample.UserTypes;

namespace UserExample.Base
{
    public class NormalUserCreator : Base.Creator
    {
        public override IUser FactoryMethod()
        {
            return new Normal(); 
        }
    }
}
