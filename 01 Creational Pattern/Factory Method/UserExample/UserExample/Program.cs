using UserExample.Base;
using UserExample.Creator;

class program
{
    static void Main(string[] args)
    {
        new CreateUser().Main();
    }

}

class CreateUser
{
    public void Main()
    {
        CreateHandler(new AdminUserCreator());
        CreateHandler(new NormalUserCreator());
        CreateHandler(new GuestUserCreator());
    }
    public void CreateHandler(Creator creator)
    {
        creator.CreateUser();
        Console.WriteLine();
    }
}

