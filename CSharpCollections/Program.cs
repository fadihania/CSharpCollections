List<string> colors = new()
{
    "RED",
    "GREEN",
    "BLUE",
    "YELLOW",
    "WHITE",
    "BLACK"
};

// LINQ on List
var lastColors = colors
    .OrderDescending()
    .Take(3)
    .ToList();
foreach (var color in lastColors)
    Console.WriteLine(color);
Console.WriteLine("---------------------------------------------");


var stds = new Dictionary<string, string>();

stds.Add("120210003", "Ahmad");
stds.Add("120210002", "Omar");
stds.Add("120210005", "Saleem");
stds.Add("120210004", "Ali");
stds.Add("120210001", "Hamza");

// LINQ on Dictionary
Console.WriteLine(stds.FirstOrDefault());
Console.WriteLine("---------------------------------------------");

foreach (var std in stds)
    Console.WriteLine(std);
Console.WriteLine("---------------------------------------------");

var stda = stds
    .Where(s => s.Value.ToLower().StartsWith("a"))
    .ToList();
foreach (var std in stda)
    Console.WriteLine(std);
Console.WriteLine("---------------------------------------------");

var stdo = stds
    .OrderBy(s => s.Value)
    .ToList();
foreach (var std in stdo)
    Console.WriteLine(std);
Console.WriteLine("---------------------------------------------");

stdo = stds
    .OrderBy(s => s.Key)
    .ToList();
foreach (var std in stdo)
    Console.WriteLine(std);
Console.WriteLine("---------------------------------------------");

stdo = stds
    .OrderByDescending(s => s.Key)
    .ToList();
foreach (var std in stdo)
    Console.WriteLine(std);
Console.WriteLine("---------------------------------------------");
