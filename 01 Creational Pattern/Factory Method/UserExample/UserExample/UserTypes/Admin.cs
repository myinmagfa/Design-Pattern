using UserExample.Base;

namespace UserExample.UserTypes
{
    public class Admin:IUser
    {
        public void CreateUser()
        {
            Console.WriteLine("Create Admin User.");
        }
    }
}
