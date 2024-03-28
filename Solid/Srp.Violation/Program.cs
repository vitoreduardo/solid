// See https://aka.ms/new-console-template for more information
using Srp.Violation;

Console.WriteLine("SRP Principle - Violation");

var employee = new Employee("John Frusciante", 2000, 60);

Console.WriteLine(employee.PrintReport());

employee.SaveData();
