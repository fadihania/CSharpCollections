var stds = new Dictionary<string, string>();

stds.Add("120210003", "Ahmad");
stds.Add("120210002", "Omar");
stds.Add("120210005", "Saleem");
stds.Add("120210004", "Ali");
stds.Add("120210001", "Hamza");

foreach (var std in stds)
{
    Console.WriteLine($"{std.Key}: {std.Value}");
}

