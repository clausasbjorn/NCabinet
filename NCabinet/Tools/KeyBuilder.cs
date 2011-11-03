using System;
using NCabinet.Inspection;

namespace NCabinet.Tools
{
    public static class KeyBuilder
    {
        public static string Build(Type type, CallerInfo caller, params object [] components)
        {
            if (caller == null)
                return String.Format("NCabinet:{0}:{1}", type.FullName, String.Join(".", components));

            return String.Format("NCabinet:{0}:{1}.{2}", type.FullName, caller.FullMethodName, String.Join(".", components));
        }
    }
}