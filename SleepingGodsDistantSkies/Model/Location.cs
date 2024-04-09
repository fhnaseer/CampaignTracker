namespace SleepingGodsDistantSkies.Model;

public class Location(int number)
{
    public int Number { get; set; } = number;

    internal List<Location> Locations { get; set; } = [];

    internal string? RequiredKeyword { get; set; }

    internal Challenge? RequiredChallenge { get; set; }

    internal LocationStatus LocationStatus { get; set; }

    public override string ToString()
    {
        return $"{Number}: {LocationStatus}";
    }
}
