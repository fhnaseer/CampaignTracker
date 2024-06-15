namespace SleepingGodsDistantSkies.StaticContent;

internal static class StoryData
{
    public static ObservableCollection<Town> GetDistantSkiesTowns()
    {
        Town serracksEdge = GetSerracksEdge();
        Town tundra = GetTundra();
        Town godEye = GetGodEye();

        Town stormlockCity = GetStormlockCity();
        Town tharkolm = GetTharkolm();
        Town milius = GetMilius();

        Town locifa = GetLocifa();
        Town henrikCamp = GetHenrikCamp();
        Town thistletown = GetThistletown();

        return [serracksEdge, tundra, godEye, stormlockCity, tharkolm, milius, locifa, henrikCamp, thistletown];
    }

    private static Town GetSerracksEdge()
    {
        Town town = new("Serracks Edge");
        town.Stories.Add(new("25"));
        town.Stories.Add(new("37"));
        town.Stories.Add(new("41"));
        town.Stories.Add(new("55"));
        town.Stories.Add(new("63"));
        town.Stories.Add(new("69"));
        town.Stories.Add(new("74"));
        town.Stories.Add(new("83"));
        town.Stories.Add(new("94"));
        return town;
    }

    private static Town GetTundra()
    {
        Town town = new("Tundra");
        town.Stories.Add(new("29"));
        town.Stories.Add(new("43"));
        town.Stories.Add(new("56"));
        town.Stories.Add(new("61"));
        town.Stories.Add(new("73"));
        town.Stories.Add(new("82"));
        town.Stories.Add(new("97"));
        return town;
    }

    private static Town GetGodEye()
    {
        Town town = new("God Eye");
        town.Stories.Add(new("19"));
        town.Stories.Add(new("30"));
        town.Stories.Add(new("42"));
        town.Stories.Add(new("62"));
        town.Stories.Add(new("70"));
        town.Stories.Add(new("81"));
        town.Stories.Add(new("85"));
        town.Stories.Add(new("87"));
        return town;
    }

    private static Town GetStormlockCity()
    {
        Town town = new("Stormlock City");
        town.Stories.Add(new("17"));
        town.Stories.Add(new("21"));
        town.Stories.Add(new("36"));
        town.Stories.Add(new("40"));
        town.Stories.Add(new("49"));
        town.Stories.Add(new("51"));
        town.Stories.Add(new("53"));
        town.Stories.Add(new("65"));
        town.Stories.Add(new("84"));
        town.Stories.Add(new("86"));
        town.Stories.Add(new("92"));
        town.Stories.Add(new("96"));
        return town;
    }

    private static Town GetTharkolm()
    {
        Town town = new("Tharkolm");
        town.Stories.Add(new("15"));
        town.Stories.Add(new("23"));
        town.Stories.Add(new("24"));
        town.Stories.Add(new("28"));
        town.Stories.Add(new("32"));
        town.Stories.Add(new("44"));
        town.Stories.Add(new("45"));
        town.Stories.Add(new("54"));
        town.Stories.Add(new("64"));
        town.Stories.Add(new("75"));
        town.Stories.Add(new("78"));
        town.Stories.Add(new("90"));
        return town;
    }

    private static Town GetMilius()
    {
        Town town = new("Milius");
        town.Stories.Add(new("16"));
        town.Stories.Add(new("20"));
        town.Stories.Add(new("31"));
        town.Stories.Add(new("33"));
        town.Stories.Add(new("38"));
        town.Stories.Add(new("46"));
        town.Stories.Add(new("57"));
        town.Stories.Add(new("59"));
        town.Stories.Add(new("68"));
        town.Stories.Add(new("72"));
        town.Stories.Add(new("80"));
        town.Stories.Add(new("88"));
        town.Stories.Add(new("89"));
        return town;
    }

    private static Town GetLocifa()
    {
        Town town = new("Locifa");
        town.Stories.Add(new("14"));
        town.Stories.Add(new("26"));
        town.Stories.Add(new("39"));
        town.Stories.Add(new("50"));
        town.Stories.Add(new("52"));
        town.Stories.Add(new("58"));
        town.Stories.Add(new("66"));
        town.Stories.Add(new("71"));
        town.Stories.Add(new("77"));
        town.Stories.Add(new("95"));
        return town;
    }

    private static Town GetHenrikCamp()
    {
        //Town henrikCamp = new("Henrik Camp", "henrik_camp.png", 2, 3);
        Town town = new("Henrik Camp");
        town.Stories.Add(new("1"));
        town.Stories.Add(new("2"));
        town.Stories.Add(new("4"));
        town.Stories.Add(new("5"));
        town.Stories.Add(new("6"));
        town.Stories.Add(new("7"));
        town.Stories.Add(new("8"));
        town.Stories.Add(new("9"));
        town.Stories.Add(new("10"));
        town.Stories.Add(new("11"));
        town.Stories.Add(new("12"));
        return town;
    }

    private static Town GetThistletown()
    {
        Town town = new("Thistletown");
        town.Stories.Add(new("13"));
        town.Stories.Add(new("22"));
        town.Stories.Add(new("27"));
        town.Stories.Add(new("34"));
        town.Stories.Add(new("35"));
        town.Stories.Add(new("47"));
        town.Stories.Add(new("48"));
        town.Stories.Add(new("60"));
        town.Stories.Add(new("67"));
        town.Stories.Add(new("76"));
        town.Stories.Add(new("79"));
        town.Stories.Add(new("91"));
        town.Stories.Add(new("93"));
        return town;
    }
}
