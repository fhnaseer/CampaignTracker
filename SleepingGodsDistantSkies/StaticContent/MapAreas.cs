using SleepingGodsDistantSkies.Model;
using System.Collections.ObjectModel;

namespace SleepingGodsDistantSkies.StaticContent;

internal static class MapAreas
{
    public static ObservableCollection<MapArea> GetMapAreas()
    {
        MapArea serracksEdge = new("Serracks Edge", "Serracks_edge.png", 14, 15);
        MapArea tundra = new("Tundra", "tundra.png", 16, 17);
        MapArea godEye = new("God Eye", "god_eye.png", 16, 17);

        MapArea stormlockCity = new("Stormlock City", "stormlock_city.png", 8, 9);
        MapArea tharkolm = new("Tharkolm", "tharkolm.png", 10, 11);
        MapArea milius = new("Milius", "milius.png", 12, 13);

        MapArea locifa = new("Locifa", "locifa.png", 6, 7);
        MapArea henrikCamp = GetHenrikCamp();
        MapArea thistletown = new("Thistletown", "thistletown.png", 4, 5);
        return [serracksEdge, tundra, godEye, stormlockCity, tharkolm, milius, locifa, henrikCamp, thistletown];
    }

    private static MapArea GetHenrikCamp()
    {
        MapArea henrikCamp = new("Henrik Camp", "henrik_camp.png", 2, 3);
        henrikCamp.Locations.Add(new(1));
        henrikCamp.Locations.Add(new(2));
        henrikCamp.Locations.Add(new(4));
        henrikCamp.Locations.Add(new(5));
        henrikCamp.Locations.Add(new(6));
        henrikCamp.Locations.Add(new(7));
        henrikCamp.Locations.Add(new(8));
        henrikCamp.Locations.Add(new(9));
        henrikCamp.Locations.Add(new(10));
        henrikCamp.Locations.Add(new(11));
        henrikCamp.Locations.Add(new(12));
        return henrikCamp;
    }
}
