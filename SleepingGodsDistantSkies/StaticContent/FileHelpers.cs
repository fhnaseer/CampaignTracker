﻿using System.Text.Json;

namespace SleepingGodsDistantSkies.StaticContent;

internal static class FileHelpers
{
    private const string _prefix = "fhn_sleepingGods_distantSkies_";
    private const string _campaignsListFilename = _prefix + "campaignNames";
    private const string _campaignFilenamePrefix = _prefix + "campaign_";

    public static CampaignData CreateCampaign(string campaignName)
    {
        string path = Path.Combine(FileSystem.Current.AppDataDirectory, _campaignsListFilename);
        using Stream fileStream = File.Open(path, FileMode.Append);
        using StreamWriter fileWriter = new(fileStream);
        fileWriter.WriteLine(campaignName);

        CampaignData campaign = new(campaignName);
        SaveCampaign(campaign);

        return campaign;
    }

    public static async Task<ObservableCollection<CampaignData>> GetCampaigns()
    {
        string fileContent = await ReadTextFile(_campaignsListFilename).ConfigureAwait(false);
        string[] campaignNames = fileContent.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        ObservableCollection<CampaignData> campaigns = [];

        foreach (string name in campaignNames)
        {
            string path = Path.Combine(FileSystem.Current.AppDataDirectory, _campaignFilenamePrefix + name);

            if (File.Exists(path))
            {
                using Stream fileStream = File.Open(path, FileMode.Open);
                CampaignData? campaign = await JsonSerializer.DeserializeAsync<CampaignData>(fileStream).ConfigureAwait(false);

                if (campaign is not null)
                {
                    campaigns.Add(campaign);
                }
            }
        }

        return campaigns;
    }

    public static void SaveCampaign(CampaignData campaign)
    {
        string path = Path.Combine(FileSystem.Current.AppDataDirectory, _campaignFilenamePrefix + campaign.Name);
        using Stream campaingStream = File.OpenWrite(path);
        using StreamWriter campaingWriter = new(campaingStream);
        campaingWriter.Write(JsonSerializer.Serialize(campaign));
    }

    public static async Task<string> ReadTextFile(string filename)
    {
        string path = Path.Combine(FileSystem.Current.AppDataDirectory, filename);
        using Stream fileStream = File.Open(path, FileMode.OpenOrCreate);
        using StreamReader reader = new(fileStream);

        return await reader.ReadToEndAsync().ConfigureAwait(false);
    }
}
