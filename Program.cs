using StreamingPlatform.Models;

var origin = new Film("Origén", 120, "Christopher Nolan");
var goodFellas = new Film("Uno de los nuestros", 95, "Martin Scorsese");
var twinPeaks = new Film("Twin Peaks", 2000, "David Lynch");
var mindHunter = new Film("Mindhunter", 1800, "David Fincher");
var freeSolo = new Film("Free Solo", 65, "Jimmy Chin");

var allContent = new List<Content>
{
    origin,
    goodFellas,
    twinPeaks,
    mindHunter,
    freeSolo
};

Console.WriteLine("Listado de películas: ");
foreach(var content in allContent)
{
    Console.WriteLine(content.GetDescription());
}

Console.Write("\nTítulo a buscar: ");

string searchTitle = Console.ReadLine();
string modifiedInput = searchTitle.Trim().ToLower();

if (string.IsNullOrWhiteSpace(modifiedInput))
{
    Console.WriteLine("Debes escribir el nombre de la película.");
    return;
}

var found = false;
foreach (var content in allContent)
{
    if (modifiedInput.Equals(content.Title.Trim().ToLower()))
    {
        Console.WriteLine($"Contenido encontrado: \n{ content.GetDescription() }");
        found = true;
        break;
    }
}

if (!found)
{
    Console.WriteLine("Título no encontrado.");    
}