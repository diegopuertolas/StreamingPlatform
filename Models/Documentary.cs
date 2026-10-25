namespace StreamingPlatform.Models;

public class Documentary : Content
{
    public string Theme { get; set; }

    public Documentary(string name, int duration, string theme)
        : base(name, duration)
    {
        Theme = theme;
    }

    public override string GetDescription()
    {
        return $"Título: {Title} | Duración: {Duration} | Temática: {Theme}";
    }
}