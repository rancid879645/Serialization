using System.Text;
using CommonLibrary;
using JsonSerialization;

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
    JsonSerializationHelper.Serialize(department, filePath);
}

Console.WriteLine("Deserialized Department:");

if (filePath != null)
{
    var deserializedDepartment = JsonSerializationHelper.Deserialize<Department>(filePath);
    var resultSb = new StringBuilder();
    resultSb.Append($"Department Name: {deserializedDepartment.DepartmentName}\n");
    foreach (var employee in deserializedDepartment.Employees)
    {
        resultSb.Append($"Employee Name: {employee.EmployeeName} \n");
    }
    Console.WriteLine(resultSb.ToString());
}

Console.WriteLine("Thanks for use our serializer :P");