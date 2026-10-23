using System.Text.Json;

namespace MyBlazorApp.Services;

public class JsonDataService
{
    private readonly string dataFolder;

    public JsonDataService()
    {
        dataFolder = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Data"
        );
    }

    public async Task SaveDataAsync<T>(string fileName, List<T> data)
    {
        string filePath = Path.Combine(dataFolder, fileName);

        string json = JsonSerializer.Serialize(
            data,
            new JsonSerializerOptions
            {
                WriteIndented = true
            }
        );

        await File.WriteAllTextAsync(filePath, json);
    }

    public async Task<List<T>> LoadDataAsync<T>(string fileName)
    {
        string filePath = Path.Combine(dataFolder, fileName);

        if (!File.Exists(filePath))
        {
            return new List<T>();
        }

        string json = await File.ReadAllTextAsync(filePath);

        return JsonSerializer.Deserialize<List<T>>(json)
               ?? new List<T>();
    }
}