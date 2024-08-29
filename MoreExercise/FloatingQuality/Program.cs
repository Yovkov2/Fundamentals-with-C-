const double esp = 0.000001;
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());  

double difference = Math.Abs(a - b);

if(difference < esp)
{
    Console.WriteLine("The numbers are equal.");
}
else
{
    Console.WriteLine("The numbers are not equal.");
}