using System.Diagnostics;
using System.Reflection;
using NCabinet.Exceptions;

namespace NCabinet.Inspection
{
    public static class CallAnalyzer
    {
        /// <summary>
        /// Analyzes the method call stack to find information about the
        /// method that invoked the call to the cache manager.
        /// </summary>
        /// <returns>Information about the calling method</returns>
        public static CallerInfo GetCallerInfo()
        {
            var count = 2;
            var stack = new StackTrace();
            while (true)
            {
                var frame = stack.GetFrame(count++);

                if (frame == null)
                    throw new CallingMethodNotFoundException();

                var method = frame.GetMethod();
                if (method == null || method.DeclaringType.FullName == null || method.DeclaringType.FullName.StartsWith("NCabinet.CacheManager"))
                    continue;

                var declarer = method.DeclaringType.FullName;
                var name = method.Name;

                return new CallerInfo() { Namespace = declarer, Method = name };
            }
        }

        /// <summary>
        /// Wraps information about the callback method.
        /// </summary>
        /// <param name="method">Information about the callback</param>
        /// <returns>Wrapped information about the callback</returns>
        public static CallerInfo GetCallbackInfo(MethodInfo method)
        {
            var declarer = method.DeclaringType.FullName;
            var name = method.Name;

            return new CallerInfo() { Namespace = declarer, Method = name };
        }
    }
}