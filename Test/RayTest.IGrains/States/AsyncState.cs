﻿using ProtoBuf;
using Ray.Core.EventSourcing;
using System;

namespace RayTest.IGrains.States
{
    [ProtoContract(ImplicitFields = ImplicitFields.AllFields)]
    public  class AsyncState<T> : IState<T>
    {
        public T StateId { get; set; }
        public long Version { get; set; }
        public long DoingVersion { get; set; }
        public DateTime VersionTime { get; set; }
    }
}
