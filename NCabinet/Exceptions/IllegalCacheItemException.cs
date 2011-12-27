using System;

namespace NCabinet.Exceptions
{
    /// <summary>
    /// The item returned from the cache is not wrapped in a valid CacheItem object.
    /// </summary>
    public class IllegalCacheItemException : Exception
    {
    }
}