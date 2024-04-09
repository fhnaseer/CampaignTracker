namespace SleepingGodsDistantSkies.Model;

public class Location
{
    internal List<Location> Locations { get; set; } = [];

    internal string? RequiredKeyword { get; set; }

    internal Challenge? RequiredChallenge { get; set; }

    internal LocationStatus LocationStatus { get; set; }
}
