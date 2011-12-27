using System;
using NCabinet.Inspection;

namespace NCabinet.Tools
{
    /// <summary>
    /// Tool for building keys following a specific pattern belonging to NCabinet
    /// </summary>
    public static class KeyBuilder
    {
        /// <summary>
        /// Returns a key consisting of the NCabinet identifier, the return type, 
        /// calling method identifiers and the parameters used when invoking the callback.
        /// </summary>
        /// <param name="type">The return type of the cache call</param>
        /// <param name="caller">Information about the method that invoked the call</param>
        /// <param name="components">The parameters provided to the callback</param>
        /// <returns></returns>
        public static string Build(Type type, CallerInfo caller, params object [] components)
        {
            if (caller == null)
                return String.Format("NCabinet:{0}:{1}", type.FullName, String.Join(".", components));

            return String.Format("NCabinet:{0}:{1}.{2}", type.FullName, caller.FullMethodName, String.Join(".", components));
        }

        /// <summary>
        /// Builds a group key
        /// </summary>
        /// <param name="keys">The group identifiers</param>
        /// <returns></returns>
        public static string Build(params string[] keys)
        {
            return String.Format("NCabinet:Group:{0}", String.Join(".", keys));
        }
    }
}