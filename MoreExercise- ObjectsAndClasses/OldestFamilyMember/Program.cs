using System.Security.Principal;
Family family = new Family();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    int age = int.Parse(input[1]);

    Person person = new Person
    {
        Name = name,
        Age = age
    };

    family.AddMember(person);
}

Person oldestMember = family.GetOldestMember();

if (oldestMember != null)
{
    Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
}
