using StreamingPlatform.Models;

public static class AppMenu
{
    public static void DisplayMenu(List<Content> contents)
    {
        var option = -1;

        do
        {
            ShowMenu();
            option = ChooseOption();

            switch (option)
            {
                case 1:
                    Console.WriteLine();
                    GetContent(contents);
                    break;
                case 2:
                    Console.WriteLine();
                    GetFilms(contents);
                    break;
                case 3:
                    Console.WriteLine();
                    GetSeries(contents);
                    break;
                case 4:
                    Console.WriteLine();
                    GetDocumentaries(contents);
                    break;
                case 5:
                    Console.WriteLine();
                    SearchFilm(contents);
                    break;
                case 0:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción incorrecta. Elija un número del 0 al 5.");
                    break;
            }

        } while (option != 0);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n === PLATAFORMA DE STREAMING ===");
        Console.WriteLine("1. Mostrar todo el contenido");
        Console.WriteLine("2. Mostrar películas");
        Console.WriteLine("3. Mostrar series");
        Console.WriteLine("4. Mostrar documentales");
        Console.WriteLine("5. Buscar película");
        Console.WriteLine("0. Salir");
    }

    public static int ChooseOption()
    {
        Console.Write("\nElija una opción: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var decision))
        {
            return -1;
        }

        return decision;
    }

    public static void GetContent(List<Content> contents)
    {
        Console.WriteLine();
        foreach (var content in contents)
        {
            Console.WriteLine(content.GetDescription());
        }
    }

    public static void GetFilms(List<Content> contents)
    {
        Console.WriteLine();

        var found = false;

        foreach (var content in contents)
        {
            if (content is Film)
            {
                Console.WriteLine(content.GetDescription());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo se han encontrado películas.");
        }
    }

    public static void GetSeries(List<Content> contents)
    {
        Console.WriteLine();

        var found = false;

        foreach (var content in contents)
        {
            if (content is Series)
            {
                Console.WriteLine(content.GetDescription());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo se han encontrado series.");
        }
    }

    public static void GetDocumentaries(List<Content> contents)
    {
        Console.WriteLine();

        var found = false;

        foreach (var content in contents)
        {
            if (content is Documentary)
            {
                Console.WriteLine(content.GetDescription());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo se han encontrado documentales.");
        }
    }

    public static void SearchFilm(List<Content> contents)
    {
        Console.Write("\nTítulo a buscar: ");
        var searchTitle = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(searchTitle))
        {
            Console.WriteLine("\nDebes escribir el nombre de la película.");
            return;
        }

        searchTitle = searchTitle.Trim().ToLower();

        var found = false;

        foreach (var content in contents)
        {
            if (searchTitle.Equals(content.Title.Trim().ToLower()))
            {
                Console.WriteLine($"\nContenido encontrado: {content.GetDescription()}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nTítulo no encontrado.");
        }
    }
}