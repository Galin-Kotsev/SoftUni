﻿int length = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Predicate<string> checkLength = x => x.Length <= length;
List<string> filteredNames = names.Where(x => checkLength(x)).ToList();
filteredNames.ForEach(x => Console.WriteLine(x));
