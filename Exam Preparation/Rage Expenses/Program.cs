int lostGames = int.Parse(Console.ReadLine());
double priceHeadset = double.Parse(Console.ReadLine());
double priceMouse = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());
int countLosts = 0;

double sum = 0;
for (int i = 1; i <= lostGames; i++)
{
    countLosts++;
    if(countLosts % 2 == 0)
    {
        sum += priceHeadset;
    }
    else if(countLosts % 3 == 0)
    {
        sum += priceMouse;
    }
    else if(countLosts % 2 == 0 && countLosts % 3 == 0)
    {
        sum += keyboardPrice;
    }
    else if(countLosts % 5 == 0)
    {
        sum += displayPrice;
    }
}
Console.WriteLine($"Rage expenses: {sum:f2} lv.");