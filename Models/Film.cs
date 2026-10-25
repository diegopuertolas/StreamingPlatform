namespace StreamingPlatform.Models;

public class Film : Content
{
    public string Director { get; set; }

    public Film(string name, int duration, string director)
        : base(name, duration)
    {
        Director = director;
    }

    public override string GetDescription()
    {
        return $"Título: {Title} | Duración: {Duration} | Director: {Director}";
    }
}