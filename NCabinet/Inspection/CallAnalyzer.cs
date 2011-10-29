using System;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using NCabinet.Exceptions;

namespace NCabinet.Inspection
{
    public static class CallAnalyzer
    {
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

        public static CallerInfo GetCallbackInfo(MethodInfo method)
        {
            var declarer = method.DeclaringType.FullName;
            var name = method.Name;

            return new CallerInfo() { Namespace = declarer, Method = name };
        }
    }


}