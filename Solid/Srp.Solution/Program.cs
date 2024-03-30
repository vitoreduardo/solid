

using Srp.Solution;

Console.WriteLine("SRP Principle - Solution");

var employee = new Employee("John Frusciante", 2000, 60);

Console.WriteLine(EmployeeService.PrintReport(employee));

EmployeeDAO.SaveData(employee);

