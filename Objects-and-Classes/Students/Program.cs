int count = int.Parse(Console.ReadLine());
List<Students> students = new List<Students>();
for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries);
    string firstName = tokens[0];
    string lastName = tokens[1];
    double grade = double.Parse(tokens[2]);
    Students student = new Students(firstName, lastName, grade);
    students.Add(student);
}
students.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ToList();
List<Students> sortedStudents = students.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ThenBy(t => t.LastName).ToList();
foreach (var item in sortedStudents)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
}
public class Students
{
    public Students(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public double Grade { get; private set; }
}