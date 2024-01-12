using ProtoBuf;

namespace Task3Clonable.Model
{
    [Serializable]
    [ProtoContract]
    public class Employee
    {
        [ProtoMember(1)]
        public string EmployeeName { get; set; }
    }
}
