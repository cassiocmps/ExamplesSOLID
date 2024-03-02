namespace SingleResponsibilityPrinciple;

public interface IEmployeeManager
{
    public void SaveEmployee(Employee emp);
    public Employee GetEmployeeById(int id);
}

public class EmployeeManager : IEmployeeManager
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

    // This method should not be here, according to SRP.
    // If the report changes in any way, a data access class will change.
    public void GenerateReport(int id)
    {
        if (EmployeesTable.ContainsKey(id))
        {
            var emp = EmployeesTable[id];
            Console.WriteLine($"Employee {emp.Id}: Name {emp.Name} Salary: {emp.Salary}");
        }
        else
        {
            Console.WriteLine($"Employee {id} not found in the database.");
        }
    }
}
