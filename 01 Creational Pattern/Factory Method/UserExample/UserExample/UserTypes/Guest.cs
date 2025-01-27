using UserExample.Base;

namespace UserExample.UserTypes
{
    public class Guest : IUser
    {
        public void CreateUser()
        {
            Console.WriteLine("Create Guest User.");
        }
    }
}
