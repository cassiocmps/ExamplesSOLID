namespace ValidPayrollCalculator;

internal class ValidPayrollCalculator
{
    protected double Balance;

    // By using inversion of control, now ValidPayrollCalculator.CalculatePayment can work with any class that implements IRemunerated
    // without needing to modify its implementation

    public void CalculatePayment(IEmploymentContract employee)
    {
        Balance = employee.CalculateCompensation();
    }
}

internal interface IEmploymentContract
{
    public double CalculateCompensation();
}

internal class Employee : IEmploymentContract
{
    public double CalculateCompensation()
    {
        return 0;
    }
}

internal class Intern : IEmploymentContract
{
    public double CalculateCompensation()
    {
        return 0;
    }
}

internal class Contractor : IEmploymentContract
{
    public double CalculateCompensation()
    {
        return 0;
    }
}
