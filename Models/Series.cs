namespace StreamingPlatform.Models;

public class Series : Content
{
    public int NumberOfSeasons { get; set; }

    public Series(string name, int duration, int numberOfSeasons)
        : base(name, duration)
    {
        NumberOfSeasons = numberOfSeasons;
    }

    public override string GetDescription()
    {
        return $"Título: {Title} | Duración: {Duration} | Número de Temporadas: {NumberOfSeasons}";
    }
}