namespace StreamingPlatform.Models;

public abstract class Content
{
    public string Title { get; set; }
    public double Duration { get; set; }

    public Content(string title, double duration)
    {
        Title = title;
        Duration = duration;
    }

    public abstract string GetDescription();
}