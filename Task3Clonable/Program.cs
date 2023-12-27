
using Task3Clonable.Model;

var department = new Department
{
    DepartmentName = "IT",
    Employees = { new Employee { EmployeeName = "Laura Villa" } }
};
var clonedDepartment = department.Clone() as Department;

Console.WriteLine($"Original Department: {department.DepartmentName}");

foreach (var employee in department.Employees)
{
    Console.WriteLine($"Original Employee: {employee.EmployeeName}");
}

Console.WriteLine($"Cloned Department: {clonedDepartment?.DepartmentName}");

foreach (var employee in clonedDepartment?.Employees)
{
    Console.WriteLine($"Cloned Employee: {employee.EmployeeName}");
}