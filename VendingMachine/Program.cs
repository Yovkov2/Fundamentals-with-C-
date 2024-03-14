string command = Console.ReadLine();
double money = 0;
while(command != "Start")
{
    double price = double.Parse(command);
    if(price == 0.1 || price == 0.2 || price == 0.5 || price == 1 || price == 2)
    {
        money  += price;
    }
    else
    {
        Console.WriteLine($"Cannot accept {price}");
    }
    command = Console.ReadLine();
}
string productName = Console.ReadLine();
while(productName != "End")
{
    if (productName == "Nuts")
    {
        if (money >= 2)
        {
            Console.WriteLine($"Purchased {productName}");
            money -= 2;
        }
        else
        {
            Console.WriteLine($"Sorry, not enough money");
        }
    }
    else if (productName == "Water")
    {
        if (money >= 0.7)
        {
            Console.WriteLine($"Purchased {productName}");
            money -= 0.7;
        }
        else
        {
            Console.WriteLine($"Sorry, not enough money");
        }
    }
    else if (productName == "Crisps")
    {
        if (money >= 1.5)
        {
            Console.WriteLine($"Purchased {productName}");
            money -= 1.5;
        }
        else
        {
            Console.WriteLine($"Sorry, not enough money");
        }
    }
    else if (productName == "Soda")
    {
        if (money >= 0.8)
        {
            Console.WriteLine($"Purchased {productName}");
            money -= 0.8;
        }
        else
        {
            Console.WriteLine($"Sorry, not enough money");
        }
    }
    else if (productName == "Coke")
    {
        if (money >= 1)
        {
            Console.WriteLine($"Purchased {productName}");
            money -= 1;
        }
        else
        {
            Console.WriteLine($"Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product.");
    }
    productName = Console.ReadLine();
}
Console.WriteLine($"Change: {money:f2}");