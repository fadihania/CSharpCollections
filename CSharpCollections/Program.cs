//var colors = new List<string>();
//List<string> colors = new List<string>();
List<string> colors = new();

Console.WriteLine($"Count: {colors.Count}");

colors.Add("RED");
colors.Add("GREEN");
colors.Add("BLUE");
colors.Add("YELLOW");
colors.Add("WHITE");
colors.Add("BLACK");

Console.WriteLine($"Count: {colors.Count}");

Console.WriteLine("---------------------------------------------");
for (var i = 0; i < colors.Count; i++)
{
    Console.WriteLine(colors[i]);
}

// Updating a list item
colors[3] = "BROWN";

// Removing an element
colors.RemoveAt(4);


Console.WriteLine("---------------------------------------------");
for (var i = 0; i < colors.Count; i++)
{
    Console.WriteLine(colors[i]);
}