using ProtoBuf;
using System.Collections.Generic;

namespace CommonLibrary
{
    [ProtoContract]
    public class Department
    {
        [ProtoMember(1)]
        public string DepartmentName{ get; set; }
        [ProtoMember(2)]
        public List<Employee> Employees { get; set; }
    }
}
