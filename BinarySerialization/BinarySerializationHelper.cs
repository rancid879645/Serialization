using ProtoBuf;
using System.Text.Json;


namespace BinarySerialization
{
    public static class BinarySerializationHelper
    {
        public static void Serialize<T>(T data, string filePath)
        {
            using var file = File.Create(filePath);
            Serializer.Serialize(file, data);
        }

        public static T? Deserialize<T>(string filePath)
        {
            using var file = File.OpenRead(filePath);
            return Serializer.Deserialize<T>(file);
        }
    }
}
