namespace SingleResponsibilityPrinciple;

public class ReportGenerator(EmployeeRepository repo)
{
    private readonly EmployeeRepository _employeeRepository = repo;

    public void GenerateReport(int id)
    {
        Employee emp = _employeeRepository.GetEmployeeById(id);

        if (emp != null)
            Console.WriteLine($"Employee {emp.Id}: Name {emp.Name} Salary: {emp.Salary}");
    }
}