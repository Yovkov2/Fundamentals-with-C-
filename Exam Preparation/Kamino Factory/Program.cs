int count = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

int applicationMaxSeqauence = 0;
int mostLeftIndex = int.MaxValue;
int maxSumOfOnes = 0;

int bestDna = 1;
int currentDna = 0;

int[] result = null;

while (command != "Clone them!")
{
    int[] numbers = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

    int sumOfOnes = 0;
    int maxSeauence = 0;
    int currentSequence = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == 0)
        {
            currentSequence = 0;
            continue;
        }
        sumOfOnes++;
        currentSequence++;
        if (currentSequence > maxSeauence)
        {
            maxSeauence = currentSequence;
        }
    }
    string targetString = new string('1', maxSeauence);
    int currentIndex = string.Join("", numbers).IndexOf(targetString);
    currentDna++;
    if (maxSeauence >= applicationMaxSeqauence && currentIndex < mostLeftIndex ||
                    maxSeauence == applicationMaxSeqauence && currentIndex == mostLeftIndex && sumOfOnes > maxSumOfOnes)
    {
        applicationMaxSeqauence = maxSeauence;
        mostLeftIndex = currentIndex;
        maxSumOfOnes = sumOfOnes;
        bestDna = currentDna;
        result = numbers;
    }
    command = Console.ReadLine();
}
Console.WriteLine($"Best DNA sample {bestDna} with sum: {maxSumOfOnes}.");
Console.WriteLine(string.Join(" ", result));