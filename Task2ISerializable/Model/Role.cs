using System.Runtime.Serialization;

namespace Task2ISerializable.Model
{
    public class Role : ISerializable
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(RoleId), RoleId);
            info.AddValue(nameof(RoleName), RoleName);
        }
    }
}
