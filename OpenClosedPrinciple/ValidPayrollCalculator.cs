namespace ValidPayrollCalculator;

internal class ValidPayrollCalculator
{
    protected double Balance;

    // By using inversion of control, now ValidPayrollCalculator.CalculatePayment can work with any class that implements IRemunerated
    // without needing to modify its implementation

    public void CalculatePayment(IRemunerated employee)
    {
        Balance = employee.CalculatePayment();
    }
}

internal interface IRemunerated
{
    public double CalculatePayment();
}

internal class Employee : IRemunerated
{
    public double CalculatePayment()
    {
        return 0;
    }
}

internal class Intern : IRemunerated
{
    public double CalculatePayment()
    {
        return 0;
    }
}

internal class Contractor : IRemunerated
{
    public double CalculatePayment()
    {
        return 0;
    }
}
