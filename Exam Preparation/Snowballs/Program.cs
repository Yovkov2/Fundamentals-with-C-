int count = int.Parse(Console.ReadLine());

double maxBall = 0;
int maxSnowBallSnow = 0;
int maxsnowballTime = 0;
int maxSnowballQuality = 0;

for (int i = 0; i < count; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    double value = Math.Pow((snowballSnow / snowballTime), snowballQuality);
    if(maxBall < value)
    {
        maxBall = value;
        maxSnowBallSnow = snowballSnow;
        maxsnowballTime = snowballTime;
        maxSnowballQuality = snowballQuality;
    }
}
Console.WriteLine($"{maxSnowBallSnow} : {maxsnowballTime} = {maxBall} ({maxSnowballQuality})");