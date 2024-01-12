using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CommonLibrary
{
    [Serializable]
    [ProtoContract]
    public class Department
    {
        [ProtoMember(1)]
        public string DepartmentName{ get; set; }
        [ProtoMember(2)]
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public object Clone()
        {
            return DeepCopy();
        }

        private Department DeepCopy()
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                return (Department)formatter.Deserialize(stream);
            }
        }
    }
}
