List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };

decimal positive = 0;
decimal negative = 0;
decimal zeros = 0;

foreach (var number in arr)
{
    if (number > 0)
        positive += 1;
    else if (number < 0)
        negative += 1;
    else
        zeros += 1;
}

decimal positive_proportion = positive / arr.Count;
decimal negative_proportion = negative / arr.Count;
decimal zeros_proportion = zeros / arr.Count;

Console.WriteLine(positive_proportion.ToString("N6"));
Console.WriteLine(negative_proportion.ToString("N6"));
Console.WriteLine(zeros_proportion.ToString("N6"));
