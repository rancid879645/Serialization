using ProtoBuf;

namespace CommonLibrary
{
    [ProtoContract]
    public class Employee
    {
        [ProtoMember(1)]
        public string EmployeeName{ get; set; }
    }
}
