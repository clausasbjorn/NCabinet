using System.Diagnostics;
using NCabinet.Exceptions;

namespace NCabinet.Tools
{
    public static class KeyBuilder
    {
        public static string Build(params object [] components)
        {
            var stack = new StackTrace();
            var frame = stack.GetFrame(2);
            if (frame == null)
                throw new CallingMethodNotFoundException();

            return "";
        }
    }
}