string[] userNames = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

foreach (string userName in userNames)
{
    bool ItsValidUser = true;
    if(userName.Length >= 3 && userName.Length <= 16)
    {
        foreach (var user in userName)
        {
            if(!(char.IsLetterOrDigit(user) || user == '_' || user == '-'))
            {
                ItsValidUser = false;
                break;
            }
        }
        if(ItsValidUser)
        {
            Console.WriteLine(userName);
        }
    }
}