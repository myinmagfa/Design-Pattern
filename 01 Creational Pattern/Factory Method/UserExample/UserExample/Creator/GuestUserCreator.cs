using UserExample.UserTypes;

namespace UserExample.Base
{
    public class GuestUserCreator : Creator
    {
        public override IUser FactoryMethod()
        {
            return new Guest();
        }
    }
}
