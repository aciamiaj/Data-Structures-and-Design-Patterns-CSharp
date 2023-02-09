//CreditCheckOnline.cs
internal class CreditCheckOnline : ICreditCheck
{
    private int id;

    public CreditCheckOnline()
    {
    }

    public CreditCheckOnline(int id)
    {
        this.id = id;
    }

    public CreditCheckOnline(string checkType, double v)
    {
        CheckType = checkType;
        V = v;
    }

    public string CheckType { get; }
    public double V { get; }

    public string CreditLimit()
    {
        //print if online
        return "Credit limit checked online.";
    }

    public double GetCreditCheck()
    {
        return 1000.00;
    }


}

