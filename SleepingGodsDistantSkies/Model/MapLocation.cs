namespace SleepingGodsDistantSkies.Model;

public partial class MapLocation(int number) : ObservableObject
{
    public int Number { get; set; } = number;

    public List<MapLocation> Locations { get; set; } = [];

    public string? RequiredKeyword { get; set; }

    public Challenge? RequiredChallenge { get; set; }

    [ObservableProperty]
    private LocationStatus _locationStatus;
}
