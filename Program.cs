const int MIN_SCORE = 0, MAX_SCORE = 100;

Console.Write("How many student there are? ");
int noOfStudent = int.Parse(Console.ReadLine()!);
int[] scores = new int[noOfStudent];

for (int i = 0; i < scores.Length; i++)
{
    int score;

    do
    {
        Console.Write($"Enter student {i + 1} score: ");
        score = int.Parse(Console.ReadLine()!);

        if (score < MIN_SCORE || score > MAX_SCORE)
        {
            WriteColored("Invalid score entered. Please enter a valid value", ConsoleColor.Red);
        }
    } while (score < MIN_SCORE || score > MAX_SCORE);

    scores[i] = score;
}

PrintResult(scores);

//tuple
(int passed, int failed) GetPassFailCounts(int[] scores, int passMark = 50)
{
    int passed = 0;
    int failed = 0;

    foreach (int score in scores)
    {
        _ = score >= passMark ? passed++ : failed++; // tenary operator ? :
    }

    return (passed, failed);
}

void PrintResult(int[] scores)
{
    WriteColored($"Highest score: {scores.Max()}", ConsoleColor.Green);
    Console.WriteLine($"Lowest score: {scores.Min()}");
    Console.WriteLine($"Average score: {scores.Average()}");
    (int passed, int failed) = GetPassFailCounts(scores);
    WriteColored($"Total Passed: {passed}", ConsoleColor.Green);
    WriteColored($"Total Failed: {failed}", ConsoleColor.Red);
}

void WriteColored(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}