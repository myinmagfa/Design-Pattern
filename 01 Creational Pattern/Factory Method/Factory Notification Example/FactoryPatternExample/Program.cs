using FactoryPatternExample.Creators;
using FactoryPatternExample.Logistic;

class Program
{
    static void Main(string[] args)
    {
        new Client().Main();
    }
}

class Client
{
    public void Main()
    {
        CreatorHandler(new EmailNotificationCreator());
        CreatorHandler(new SmsNotificationCreator());
        CreatorHandler(new PushNotificationCreator());
    }

    public void CreatorHandler(Creator creator)
    {
        creator.Logic();
    }
}