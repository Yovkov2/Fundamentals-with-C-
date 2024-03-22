string password = Console.ReadLine();
bool isLenghtvalid = IsPasswordLengthValid(password);
bool isPasswordAlpha = IsPasswordAlphaNumeric(password);
bool hastodigit = IsPasswordContaingAtleastTwoDigits(password);

if (!isLenghtvalid)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}
if (!isPasswordAlpha)
{
    Console.WriteLine("Password must consist only of letters and digits");
}
if (!hastodigit)
{
    Console.WriteLine("Password must have at least 2 digits");
}
if(isLenghtvalid && isPasswordAlpha && hastodigit)
{
    Console.WriteLine("Password is valid");
}
bool IsPasswordContaingAtleastTwoDigits(string password)
{
    int count = 0;
    foreach (char c in password)
    {
        if(char.IsDigit(c)) count++;
    }
    return count >= 2;
}

bool IsPasswordAlphaNumeric(string password)
{
   foreach (char c in password)
    {
        if (!char.IsLetterOrDigit(c))
        {
            return false;
        }
    }
   return true;
}


static bool IsPasswordLengthValid(string password)
{
    bool Isvalid = password.Length >= 6 && password.Length <= 10;
    return Isvalid;
}

