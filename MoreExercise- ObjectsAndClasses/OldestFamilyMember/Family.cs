public class Family
{
    public List<Person> Persons { get; set; }
    public Family()
    {
        Persons = new List<Person>();
    }
    public void AddMember(Person person)
    {
        Persons.Add(person);
    }
    public Person GetOldestMember()
    {

        return Persons.OrderByDescending(person => person.Age).FirstOrDefault();
    }
}