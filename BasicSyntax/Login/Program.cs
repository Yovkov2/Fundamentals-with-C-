string userName = Console.ReadLine();
string password = new string(userName.Reverse().ToArray());
int counts = 0; 
bool logged = false;
while(counts != 4)
{
    string name = Console.ReadLine();
    counts++;
    if(name != password)
    {
        Console.WriteLine($"Incorrect password. Try again.");
    }
    else
    {
        Console.WriteLine($"User {userName} logged in.");
        logged = true;
        break;
    }
}
if (!logged)
{
    Console.WriteLine($"User {userName} blocked!");
}
