using System.Diagnostics;

int countOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string dayOfWeek = Console.ReadLine(); 
double sum = 0;
if(typeOfGroup == "Students")
{
    if(dayOfWeek == "Friday")
    {
        sum += countOfPeople * 8.45;
    }
    else if(dayOfWeek == "Saturday")
    {
        sum += countOfPeople * 9.80;
    }
    else
    {
        sum += countOfPeople * 10.46;
    }
    if(countOfPeople >= 30)
    {
        sum -= sum * 0.15;
    }
}
else if (typeOfGroup == "Business")
{
    if(countOfPeople >= 100)
    {
        countOfPeople -= 10;
    }
    if (dayOfWeek == "Friday")
    {
        sum += countOfPeople * 10.90;
    }
    else if (dayOfWeek == "Saturday")
    {
        sum += countOfPeople * 15.60;
    }
    else
    {
        sum += countOfPeople * 16;
    }
}
else
{
    if (dayOfWeek == "Friday")
    {
        sum += countOfPeople * 15;
    }
    else if (dayOfWeek == "Saturday")
    {
        sum += countOfPeople * 20;
    }
    else
    {
        sum += countOfPeople * 22.50;
    }
    if(countOfPeople >= 10 && countOfPeople <= 20)
    {
        sum *= 0.05;
    }
}
Console.WriteLine($"Total price: {sum:f2}");