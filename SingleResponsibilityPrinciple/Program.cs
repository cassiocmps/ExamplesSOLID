using SingleResponsibilityPrinciple;

// Here EmployeeManager does both operations.
// It works fine, but the manager class changes in two situations: 
// 1. Database structure changes
// 2. Report format/data changes
var emp = new Employee { Id = 1, Name = "Cassio", Salary = 50000 };

var manager = new EmployeeManager();
manager.SaveEmployee(emp);
manager.GenerateReport(emp.Id);

// In this alternative, we have one class to handle database acces,
// that would change only when database access/structure changes and 
// A report generator, that would change only when something needs to be in the report or removed from it
var emp2 = new Employee { Id = 2, Name = "Ana Lu", Salary = 1000000 };

var repo = new EmployeeRepository();
repo.SaveEmployee(emp2);
var report = new ReportGenerator(repo);
report.GenerateReport(emp2.Id);

// A real world example for this is the Repository pattern. 
// A repository should change only when data access and persistence is changed 
