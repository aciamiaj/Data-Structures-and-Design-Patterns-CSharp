internal class Calculator
{
    private IStrategy currentStrategy;

    public Calculator()
    {
        this.currentStrategy =  new AddStrategy();
    }

    internal void SetStrategy(IStrategy strategy)
    {
        this.currentStrategy = strategy;
    }

    internal double Calculate(double v1, double v2)
    {
        return currentStrategy.Calculate(v1, v2);
    }
}