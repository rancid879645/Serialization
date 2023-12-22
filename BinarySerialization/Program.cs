// See https://aka.ms/new-console-template for more information

using BinarySerialization;
using CommonLibrary;

Console.WriteLine("Department Name:");
var departmentName = Console.ReadLine();
Console.WriteLine("Employees Names separate by /:");
var employees = Console.ReadLine()?.Split("/");
Console.WriteLine("File path to serialize:");
var filePath = Console.ReadLine();
var department = new Department();

if (employees != null && filePath != null)
{
    var employeesNames = employees.Select(employeeName => new Employee() { EmployeeName = employeeName }).ToList();
    department.Employees = employeesNames;
    department.DepartmentName = departmentName;
    BinarySerializationHelper.Serialize(department, filePath);
}

Console.WriteLine("Thanks for use our serializer :P");

