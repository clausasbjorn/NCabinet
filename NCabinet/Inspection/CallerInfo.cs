using System;

namespace NCabinet.Inspection
{
    public class CallerInfo
    {
        public string Namespace { get; set; }
        public string Method { get; set; }
        public string FullMethodName { get { return String.Format("{0}.{1}", Namespace, Method); } }
    }
}