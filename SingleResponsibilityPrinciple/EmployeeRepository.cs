namespace SingleResponsibilityPrinciple;

public interface IEmployeeRepository
{
    public void SaveEmployee(Employee emp);
    public Employee GetEmployeeById(int id);
}

public class EmployeeRepository : IEmployeeRepository
{
    private Dictionary<int, Employee> EmployeesTable = [];

    public void SaveEmployee(Employee emp)
    {
        EmployeesTable[emp.Id] = emp;
        Console.WriteLine($"Employee {emp.Id} saved to the database.");
    }

    public Employee GetEmployeeById(int id)
    {
        if (EmployeesTable.ContainsKey(id))
        {
            return EmployeesTable[id];
        }
        else
        {
            Console.WriteLine($"Employee {id} not found in the database.");
            return null;
        }
    }
}
