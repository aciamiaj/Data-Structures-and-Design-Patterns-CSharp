//CreditCheckFactory.cs
using System.Configuration;
    internal class CreditCheckFactory
    {
    static CreditCheckFactory singleton; //create singleton CreditCheckFactory
    List<string> mylist = new List<string>(new string[] { "online", "offline" });


    internal static CreditCheckFactory getSingleton()
    {
        if (singleton == null)
            singleton = new CreditCheckFactory();
        return singleton;
    }

    //return the list
   
    public List<string> getSingletonList()
    {
        return mylist;
    }

    internal ICreditCheck FactoryMethod(string? checkType, double[] limit)
    { 
        switch (checkType) //case to choose if online or offline
        {
            case "online":
                return new CreditCheckOnline(checkType, limit[0]);
            case "offline":
                return new CreditCheckOffline(checkType, limit[1]);
            default:
                return new CreditCheckOnline(checkType, limit[0]);
        }
    }
    }

internal class SingletonMain
{
    internal static void Main()
    {
        //output the list 
        CreditCheckFactory singleton = CreditCheckFactory.getSingleton();
        singleton.getSingletonList().ForEach(Console.WriteLine);
    }
}