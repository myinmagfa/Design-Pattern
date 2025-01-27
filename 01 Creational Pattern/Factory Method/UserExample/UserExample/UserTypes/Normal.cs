using UserExample.Base;

namespace UserExample.UserTypes
{
    public class Normal : IUser
    {
        public void CreateUser()
        {
            Console.WriteLine("Create Normal User.");
        }
    }
}
