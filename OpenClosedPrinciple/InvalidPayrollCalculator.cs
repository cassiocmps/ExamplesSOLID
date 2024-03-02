namespace InvalidPayrollCalculator;

public class InvalidPayrollCalculator
{
    protected double Balance;

    // Imagine we have this calculator where different rules applies to different employment formats
    // and we now want to add a Contractor model.
    // It is possible to just add another 'if' statement in the method,
    // but this approach could introduce bugs in a process already stablished 

    public void CalculatePayment(object employee)
    {
        if (employee is Employee)
        {
            Employee contract = (Employee)employee;
            Balance = contract.GetSalary();
        }
        else if (employee is Intern)
        {
            Intern internship = (Intern)employee;
            Balance = internship.GetAllowance();
        }
    }
}

internal class Employee
{
    public double GetSalary()
    {
        return 0;
    }
}

internal class Intern
{
    public double GetAllowance()
    {
        return 0;
    }
}
