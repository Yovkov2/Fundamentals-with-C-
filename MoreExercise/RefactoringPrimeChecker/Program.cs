int count = int.Parse(Console.ReadLine());
for (int i = 2; i <= count; i++)
{
    bool isValid = true;
    for (int cepitel = 2; cepitel < i; cepitel++)
    {
        if (i % cepitel == 0)
        {
            isValid = false;
            break;
        }
    }
    Console.WriteLine("{0} -> {1}", i, isValid);
}
