using Azon.Web.Sdk.Components;
using Azon.Web.Sdk.Contracts;
using System.Text.Json;

namespace Chapter06.Persistence
{
    public class JsonPersistence
        : IFilePersistence
    {
        public string FilePath { get; set; } = Path.Combine(Environment.CurrentDirectory, "From.json");
        public void Save(List<Control> controls)
        {
            var serialized = JsonSerializer.Serialize(controls);
            File.WriteAllText(FilePath, serialized);
        }
    }
}
