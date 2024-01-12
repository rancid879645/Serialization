
using Task3Clonable.Model;

var department = new Department
{
    DepartmentName = "IT",
    Employees = { new Employee { EmployeeName = "Laura Villa" } }
};
var departmentCopy = department;
var clonedDepartment = department.Clone() as Department;

Console.WriteLine($"Original Department: {department.DepartmentName}");

departmentCopy.DepartmentName = "Other";

Console.WriteLine($"Copy Department: {departmentCopy.DepartmentName}");

foreach (var employee in department.Employees)
{
    Console.WriteLine($"Copy Original Employee: {employee.EmployeeName}");
}

Console.WriteLine($"Original Department Affected after modification of copy: {department.DepartmentName}");

foreach (var employee in department.Employees)
{
    Console.WriteLine($"Original Employee: {employee.EmployeeName}");
}

clonedDepartment.DepartmentName = "Cloned IT";

Console.WriteLine($"Cloned Department: {clonedDepartment?.DepartmentName}");

foreach (var employee in clonedDepartment?.Employees)
{
    Console.WriteLine($"Cloned Employee: {employee.EmployeeName}");
}

Console.WriteLine($"Original Department without changes after mod the cloned object: {department.DepartmentName}");