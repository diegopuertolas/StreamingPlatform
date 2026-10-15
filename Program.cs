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

foreach(var content in allContent)
{
    Console.WriteLine(content.GetDescription());
}
