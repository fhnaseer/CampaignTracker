using System.Text.Json;

namespace SleepingGodsDistantSkies.StaticContent;

internal static class FileHelpers
{
    private const string _prefix = "fhn_sleepingGods_";
    private const string _campaignsListFilename = _prefix + "campaignNames";
    private const string _campaignFilenamePrefix = _prefix + "campaign_";

    public static CampaignData CreateCampaign(string campaignName, bool isDistantSkies)
    {
        string path = Path.Combine(FileSystem.Current.AppDataDirectory, _campaignsListFilename + ".json");
        using Stream fileStream = File.Open(path, FileMode.Append);
        using StreamWriter fileWriter = new(fileStream);
        fileWriter.WriteLine(campaignName);

        CampaignData campaign = new(campaignName);

        if (isDistantSkies)
            StoryData.AddDistantSkiesTowns(campaign);

        SaveCampaign(campaign);

        return campaign;
    }

    public static void DeleteCampaign(string campaignName)
    {
        string path = Path.Combine(FileSystem.Current.AppDataDirectory, _campaignFilenamePrefix + campaignName + ".json");
        File.Delete(path);
    }

    public static async Task<ObservableCollection<CampaignData>> GetCampaigns()
    {
        string fileContent = await ReadTextFile(_campaignsListFilename + ".json").ConfigureAwait(false);
        string[] campaignNames = fileContent.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        ObservableCollection<CampaignData> campaigns = [];

        foreach (string name in campaignNames)
        {
            string path = Path.Combine(FileSystem.Current.AppDataDirectory, _campaignFilenamePrefix + name + ".json");

            if (!File.Exists(path))
                continue;

            try
            {
                using Stream fileStream = File.Open(path, FileMode.Open);
                CampaignData? campaign = await JsonSerializer.DeserializeAsync<CampaignData>(fileStream).ConfigureAwait(false);

                if (campaign is not null)
                    campaigns.Add(campaign);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        return campaigns;
    }

    public static void SaveCampaign(CampaignData? campaign)
    {
        if (campaign == null) return;

        foreach (Story story in campaign.Stories.Values)
            story.Stories.Clear();

        foreach (Town town in campaign.Towns)
            town.Stories.Clear();

        string path = Path.Combine(FileSystem.Current.AppDataDirectory, _campaignFilenamePrefix + campaign.Name + ".json");
        using Stream campaingStream = File.OpenWrite(path);
        using StreamWriter campaingWriter = new(campaingStream);
        campaingWriter.Write(JsonSerializer.Serialize(campaign));
        PopulateCampaignStories(campaign);

    }

    private static void PopulateCampaignStories(CampaignData campaign)
    {
        foreach (Story story in campaign.Stories.Values)
            PopulateStories(campaign, story);

        foreach (Town town in campaign.Towns)
            PopulateTownStories(campaign, town);
    }

    public static void PopulateTownStories(CampaignData campaign, Town town)
    {
        town.Stories.Clear();

        foreach (string storyNumber in town.StoryNumbers)
        {
            if (campaign.Stories.TryGetValue(storyNumber, out Story? subStory))
                town.Stories.Add(subStory);
        }
    }

    public static void PopulateStories(CampaignData campaign, Story story)
    {
        story.Stories.Clear();

        foreach (string storyNumber in story.StoryNumbers)
        {
            if (campaign.Stories.TryGetValue(storyNumber, out Story? subStory))
                story.Stories.Add(subStory);
        }
    }

    public static async Task<string> ReadTextFile(string filename)
    {
        string path = Path.Combine(FileSystem.Current.AppDataDirectory, filename);
        using Stream fileStream = File.Open(path, FileMode.OpenOrCreate);
        using StreamReader reader = new(fileStream);

        return await reader.ReadToEndAsync().ConfigureAwait(false);
    }
}
