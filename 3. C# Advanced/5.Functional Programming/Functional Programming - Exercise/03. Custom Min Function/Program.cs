



Func<HashSet<int>, int> min = numbers =>
{
    int min = int.MaxValue;

    foreach (var number in numbers)
    {
        if (min > number)
        {
            min = number;
        }
    }

    return min;
};

HashSet<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToHashSet();

Console.WriteLine(min(numbers));