using Task2ISerializable.Model;

namespace Task2ISerializable;

public class Program
{
    private static void Main()
    {
        var role = new Role()
        {
            RoleId = 1245,
            RoleName = "Admin"
        };
        
        SerializeWithCustomSerialization(role, "customSerialization.bin");
        var deserializedObject = DeserializeWithCustomSerialization<Role>("customSerialization.bin");
        
        Console.WriteLine($"Deserialized Custom Object: RoleId - {deserializedObject.RoleId}, Property2 - {deserializedObject.RoleName}");
    }

    private static void SerializeWithCustomSerialization<T>(T obj, string filePath)
    {
        var formatter = new CustomBinaryFormatter();
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            formatter.Serialize(stream, obj);
        }
        Console.WriteLine($"Custom Binary serialized and saved to {filePath}");
    }

    private static T DeserializeWithCustomSerialization<T>(string filePath)
    {
        var formatter = new CustomBinaryFormatter();
        using var stream = new FileStream(filePath, FileMode.Open);
        return (T)formatter.Deserialize(stream);
    }
}