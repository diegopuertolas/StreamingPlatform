using StreamingPlatform.Models;

var origin = new Film("Origén", 120, "Christopher Nolan");
var goodFellas = new Film("Uno de los nuestros", 95, "Martin Scorsese");
var twinPeaks = new Series("Twin Peaks", 2000, 3);
var mindHunter = new Series("Mindhunter", 1800, 2);
var freeSolo = new Documentary("Free Solo", 65, "Climbing");

var contents = new List<Content>
{
    origin,
    goodFellas,
    twinPeaks,
    mindHunter,
    freeSolo
};

AppMenu.DisplayMenu(contents);