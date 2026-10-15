namespace StreamingPlatform.Models;

public abstract class Content
{
    public string Title { get; set; }
    public int Duration { get; set; }

    public Content(string title, int duration)
    {
        Title = title;
        Duration = duration;
    }

    public abstract string GetDescription();
}