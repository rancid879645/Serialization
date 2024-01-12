using ProtoBuf;

namespace Task3Clonable.Model
{
    [Serializable]
    [ProtoContract]
    public class Department
    {
        [ProtoMember(1)]
        public string DepartmentName { get; set; }
        [ProtoMember(2)]
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public object Clone()
        {
            return DeepCopy();
        }

        private Department DeepCopy()
        {
            using var stream = new MemoryStream();
            Serializer.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            return Serializer.Deserialize<Department>(stream);
        }
    }
}
