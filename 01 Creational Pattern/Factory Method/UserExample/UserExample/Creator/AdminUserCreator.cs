using UserExample.Base;
using UserExample.UserTypes;

namespace UserExample.Creator
{
    public class AdminUserCreator : Base.Creator
    {
        public override IUser FactoryMethod()
        {
            return new Admin();
        }
    }
}
