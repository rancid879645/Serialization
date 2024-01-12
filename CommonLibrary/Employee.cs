﻿using ProtoBuf;
using System;

namespace CommonLibrary
{
    [Serializable]
    [ProtoContract]
    public class Employee
    {
        [ProtoMember(1)]
        public string EmployeeName{ get; set; }
    }
}
