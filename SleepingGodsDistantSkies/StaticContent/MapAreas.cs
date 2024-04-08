using SleepingGodsDistantSkies.Model;

namespace SleepingGodsDistantSkies.StaticContent;

internal static class MapAreas
{
    public static MapArea[] GetMapAreas()
    {
        MapArea locifa = new("Locifa", "locifa.png", 6, 7);
        MapArea henrikCamp = new("Henrik Camp", "henrik_camp.png", 2, 3);
        MapArea thistletown = new("Thistletown", "thistletown.png", 4, 5);
        MapArea milius = new("Milius", "milius.png", 12, 13);
        MapArea tharkolm = new("Tharkolm", "tharkolm.png", 10, 11);
        MapArea stormlockCity = new("Stormlock City", "stormlock_city.png", 8, 9);
        MapArea serracksEdge = new("Serracks Edge", "Serracks_edge.png", 14, 15);
        MapArea tundra = new("Tundra", "tundra.png", 16, 17);
        MapArea godEye = new("God Eye", "god_eye", 16, 17);
        return [locifa, henrikCamp, thistletown, milius, tharkolm, stormlockCity, serracksEdge, tundra, godEye];
    }
}
