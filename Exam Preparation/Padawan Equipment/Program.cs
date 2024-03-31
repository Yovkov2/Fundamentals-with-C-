double jhonMoney = double.Parse(Console.ReadLine());
int countStudents = int.Parse(Console.ReadLine());
double priceSaber = double.Parse(Console.ReadLine());
double priceRobes = double.Parse(Console.ReadLine());
double belt = double.Parse(Console.ReadLine());

double priceSaberSum = priceSaber * (countStudents + (int)Math.Ceiling(countStudents * 0.1));
double priceRobesSum = priceRobes * countStudents;

double beltSum = belt * countStudents;

double sum = priceRobesSum + priceSaberSum + beltSum;
if(jhonMoney >= sum)
{
    Console.WriteLine($"The money is enough - it would cost {jhonMoney-sum:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {sum-jhonMoney:f2}lv more.");
}