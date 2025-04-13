namespace SleepingGodsDistantSkies.StaticContent;

internal static class StoryData
{
    public static void AddDistantSkiesTowns(CampaignData campaign)
    {
        AddTown(campaign, "Serracks Edge", ["", "25", "37", "41", "55", "63", "69", "74", "83", "94"]);
        AddTown(campaign, "Tundra", ["", "18", "29", "43", "56", "61", "73", "82", "97"]);
        AddTown(campaign, "God Eye", ["", "19", "30", "42", "62", "70", "81", "85", "87"]);

        AddTown(campaign, "Stormlock City", ["", "17", "21", "36", "40", "49", "51", "53", "65", "84", "86", "92", "96"]);
        AddTown(campaign, "Tharkolm", ["", "15", "23", "24", "28", "32", "44", "45", "54", "64", "75", "78", "90"]);
        AddTown(campaign, "Milius", ["", "16", "20", "31", "33", "38", "46", "57", "59", "68", "72", "80", "88", "89"]);

        AddTown(campaign, "Locifa", ["", "14", "26", "39", "50", "52", "58", "66", "71", "77", "95"]);
        AddTown(campaign, "Henrik Camp", ["", "1", "2", "4", "5", "6", "7", "8", "9", "10", "11", "12"]);
        AddTown(campaign, "Thistletown", ["", "13", "22", "27", "34", "35", "47", "48", "60", "67", "76", "79", "91", "93"]);
        campaign.Stories[""] = new Story("") { Status = Status.Crossed };
    }

    private static void AddTown(CampaignData campaign, string townName, string[] storyNumbers)
    {
        Town town = new(townName);
        foreach (string storyNumber in storyNumbers)
        {
            campaign.Stories[storyNumber] = new Story(storyNumber);
            town.StoryNumbers.Add(storyNumber);
        }

        campaign.Towns.Add(town);
    }
}
