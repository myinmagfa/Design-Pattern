namespace UserExample.Base
{
    public abstract class Creator
    {
        public abstract IUser FactoryMethod();
        public void CreateUser()
        {
            var user = FactoryMethod();
            user.CreateUser();
        }
    }
}
