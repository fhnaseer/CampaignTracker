namespace SleepingGodsDistantSkies.StaticContent;

internal static class StoryData
{
    public static ObservableCollection<Town> GetTowns()
    {
        //Town serracksEdge = new("Serracks Edge", "Serracks_edge.png", 14, 15);
        //Town tundra = new("Tundra", "tundra.png", 16, 17);
        //Town godEye = new("God Eye", "god_eye.png", 16, 17);

        //Town stormlockCity = new("Stormlock City", "stormlock_city.png", 8, 9);
        //Town tharkolm = new("Tharkolm", "tharkolm.png", 10, 11);
        //Town milius = new("Milius", "milius.png", 12, 13);

        //Town locifa = new("Locifa", "locifa.png", 6, 7);
        //Town henrikCamp = GetHenrikCamp();
        //Town thistletown = new("Thistletown", "thistletown.png", 4, 5);
        Town serracksEdge = new("Serracks Edge", 14, 15);
        Town tundra = new("Tundra", 16, 17);
        Town godEye = new("God Eye", 16, 17);

        Town stormlockCity = new("Stormlock City", 8, 9);
        Town tharkolm = new("Tharkolm", 10, 11);
        Town milius = new("Milius", 12, 13);

        Town locifa = new("Locifa", 6, 7);
        Town henrikCamp = GetHenrikCamp();
        Town thistletown = new("Thistletown", 4, 5);

        return [serracksEdge, tundra, godEye, stormlockCity, tharkolm, milius, locifa, henrikCamp, thistletown];
    }

    private static Town GetHenrikCamp()
    {
        //Town henrikCamp = new("Henrik Camp", "henrik_camp.png", 2, 3);
        Town henrikCamp = new("Henrik Camp", 2, 3);
        henrikCamp.Stories.Add(new("1"));
        henrikCamp.Stories.Add(new("2"));
        henrikCamp.Stories.Add(new("4"));
        henrikCamp.Stories.Add(new("5"));
        henrikCamp.Stories.Add(new("6"));
        henrikCamp.Stories.Add(new("7"));
        henrikCamp.Stories.Add(new("8"));
        henrikCamp.Stories.Add(new("9"));
        henrikCamp.Stories.Add(new("10"));
        henrikCamp.Stories.Add(new("11"));
        henrikCamp.Stories.Add(new("12"));
        return henrikCamp;
    }
}
