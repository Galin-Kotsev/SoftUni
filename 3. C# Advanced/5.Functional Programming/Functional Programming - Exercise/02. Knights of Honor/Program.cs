


Action<string[]> print = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"Sir {name}");
    }
};

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    

print(names);