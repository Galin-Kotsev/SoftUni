
Action<string[]> print
    = names => Console.WriteLine(string.Join(Environment.NewLine, names));

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(names);