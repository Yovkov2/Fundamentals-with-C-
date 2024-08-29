using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());


        int balanceCounter = 0;
        bool isBalanced = true;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (input == "(")
            {
                balanceCounter++;
                if (balanceCounter > 1)
                {
                    isBalanced = false;
                    break;
                }
            }
            else if (input == ")")
            {
                if (balanceCounter == 0)
                {
                    isBalanced = false;
                    break;
                }
                balanceCounter--;
            }
        }
        if (balanceCounter != 0)
        {
            isBalanced = false;
        }
        if (isBalanced)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}