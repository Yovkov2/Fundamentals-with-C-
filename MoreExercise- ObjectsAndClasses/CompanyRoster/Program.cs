int count = int.Parse(Console.ReadLine());
List<Employee> employees = new List<Employee>();
for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string firstName = input[0];
    double salary = double.Parse(input[1]);
    string department = input[2];
    Employee employee = new Employee();
    employee.Name = firstName;
    employee.Salary = salary;
    employee.department = department;
    employees.Add(employee);
}
var departmentAverages = employees
            .GroupBy(e => e.department)
            .Select(g => new
            {
                Department = g.Key,
                AverageSalary = g.Average(e => e.Salary)
            });

var highestAverageDepartment = departmentAverages
           .OrderByDescending(d => d.AverageSalary)
           .FirstOrDefault();

if (highestAverageDepartment == null)
{
    Console.WriteLine("No employees.");
    return;
}

var topDepartmentEmployees = employees
            .Where(e => e.department == highestAverageDepartment.Department)
            .OrderByDescending(e => e.Salary);

foreach (var employee in topDepartmentEmployees)
{
    Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
}
