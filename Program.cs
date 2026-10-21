using StreamingPlatform.Models;

var origin = new Film("Origén", 120, "Christopher Nolan");
var goodFellas = new Film("Uno de los nuestros", 95, "Martin Scorsese");
var twinPeaks = new Series("Twin Peaks", 2000, 3);
var mindHunter = new Series("Mindhunter", 1800, 2);
var freeSolo = new Documentary("Free Solo", 65, "Climbing");

var allContent = new List<Content>
{
    origin,
    goodFellas,
    twinPeaks,
    mindHunter,
    freeSolo
};

GetContent(allContent);
GetFilms(allContent);
GetSeries(allContent);
GetDocumentaries(allContent);
SearchFilm(allContent);


static void GetContent(List<Content> allContent)
{
    Console.WriteLine("LISTADO DE CONTENIDOS");
    foreach (var content in allContent)
    {
        Console.WriteLine(content.GetDescription());
    }
}

static void SearchFilm(List<Content> allContent)
{
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
            Console.WriteLine($"Contenido encontrado: \n{content.GetDescription()}");
            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("Título no encontrado.");
    }
}

static void GetFilms(List<Content> allContent)
{
    Console.WriteLine("LISTADO DE PELICULAS");
    foreach (var content in allContent)
    {
        if (content is Film)
        {
            Console.WriteLine(content.GetDescription());
        }
    }
}

static void GetSeries(List<Content> allContent)
{
    Console.WriteLine("LISTADO DE SERIES");
    foreach (var content in allContent)
    {
        if (content is Series)
        {
            Console.WriteLine(content.GetDescription());
        }
    }
}

static void GetDocumentaries(List<Content> allContent)
{
    Console.WriteLine("LISTADO DE DOCUMENTALES");
    foreach (var content in allContent)
    {
        if (content is Documentary)
        {
            Console.WriteLine(content.GetDescription());
        }
    }
}