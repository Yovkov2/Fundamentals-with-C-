string command = Console.ReadLine();
List<People> peoples = new List<People>();
while(command != "End")
{
    string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string firstName = input[0];
    string id = input[1];
    int age = int.Parse(input[2]);
    People human = new People(firstName, id, age);
    peoples.Add(human);
    command = Console.ReadLine();
}
peoples.OrderBy(t => t.Age).ThenBy(t => t.FirstName).ToList();
List<People> sortedPeople = peoples.OrderBy(t => t.Age).ThenBy(t => t.FirstName).ThenBy(t => t.Id).ToList();
foreach(var student in sortedPeople)
{
    Console.WriteLine($"{student.FirstName} with ID: {student.Id} is {student.Age} years old");
}



public class People
{
    public People(string firstName, string id, int age)
    {
        FirstName = firstName;
        Id = id;
        Age = age;
    }

    public string FirstName { get; private set; }
    public string Id { get; private set; }
    public int  Age { get; private set; }
}