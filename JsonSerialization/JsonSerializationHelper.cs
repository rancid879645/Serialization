using CommonLibrary;
using System.Text.Json;

namespace JsonSerialization
{
    public class JsonSerializationHelper
    {
        public static void Serialize(Department data, string filePath)
        {
            var serializedDepartment = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, serializedDepartment);
        }

        public static T? Deserialize<T>(string filePath)
        {
            using var file = File.OpenRead(filePath);
            return JsonSerializer.Deserialize<T>(file);
        }
    }
}
