using System.Xml.Serialization;

namespace XMLSerialization
{
    public static class XmlSerializationHelper
    {
        public static void Serialize<T>(T data, string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var stream = new FileStream(filePath, FileMode.Create);
            serializer.Serialize(stream, data);
        }

        public static T Deserialize<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var stream = new FileStream(filePath, FileMode.Open);
            return (T)serializer.Deserialize(stream)!;
        }
    }
}
