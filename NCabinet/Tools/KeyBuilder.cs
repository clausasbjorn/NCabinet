using System;
using NCabinet.Inspection;

namespace NCabinet.Tools
{
    public static class KeyBuilder
    {
        public static string Build(Type type, CallerInfo caller, params object [] components)
        {
            return String.Format("{0}:{1}.{2}", type.FullName, caller.FullMethodName, String.Join(".", components));
        }
    }
}