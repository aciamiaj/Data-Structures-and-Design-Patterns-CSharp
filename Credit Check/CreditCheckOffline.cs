//CreditCheckOffline.cs
internal class CreditCheckOffline : ICreditCheck
{
    private int id;

    public CreditCheckOffline()
    {
    }

    public CreditCheckOffline(int id)
    {
        this.id = id;
    }

    public CreditCheckOffline(string checkType, double v)
    {
        CheckType = checkType;
        V = v;
    }

    public string CheckType { get; }
    public double V { get; }

    public string CreditLimit()
    {
        //print if offline
        return "Credit limit checked offline.";
    }

    public double GetCreditCheck()
    {
        return 1000.00;
    }

}

