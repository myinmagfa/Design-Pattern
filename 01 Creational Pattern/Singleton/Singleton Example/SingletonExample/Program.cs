using SingletonExample;

class Program
{
    public static void Main(string[] args)
    {
        var s1 = Singleton.GetInstance();
        var s2 = Singleton.GetInstance();
        if (s1 == s2)
        {
            Console.WriteLine("S1 is equal S2 => singleton is correct");
        }
        else
        {
            Console.WriteLine("S1 is not equal S2 => singleton is incorrect");
        }

        Console.WriteLine();


    }
}
