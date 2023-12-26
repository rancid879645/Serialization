using System.Runtime.Serialization;
using Task2ISerializable.Model;

namespace Task2ISerializable
{
    public class CustomBinaryFormatter
    {
        public SerializationBinder Binder { get; set; }
        public StreamingContext Context { get; set; }
        public ISurrogateSelector SurrogateSelector { get; set; }

        public object Deserialize(Stream serializationStream)
        {
            var reader = new BinaryReader(serializationStream);
            var roleId = reader.ReadInt32();
            var roleName = reader.ReadString();
            return new Role{ RoleId = roleId, RoleName = roleName };
        }

        public void Serialize(Stream serializationStream, object graph)
        {
            var writer = new BinaryWriter(serializationStream);
            var customObject = (Role)graph;
            writer.Write(customObject.RoleId);
            writer.Write(customObject.RoleName);
        }
    }
}
