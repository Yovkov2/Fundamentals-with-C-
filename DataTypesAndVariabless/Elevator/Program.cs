int countPeople = int.Parse(Console.ReadLine());
int capacityPeople = int.Parse(Console.ReadLine());

int courses = (int)Math.Ceiling((double)(countPeople / capacityPeople));
Console.WriteLine(courses);