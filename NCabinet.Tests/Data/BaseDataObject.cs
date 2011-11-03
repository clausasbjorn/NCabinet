using System;

namespace NCabinet.Tests.Data
{
    public class BaseDataObject
    {
        public BaseDataObject()
        {
            Timestamp = DateTime.Now.Ticks;
        }

        public long Timestamp { get; set; }
    }
}