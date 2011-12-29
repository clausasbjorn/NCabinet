namespace NCabinet
{
    /// <summary>
    /// Used when providing a finite of sliding window expiration time for cached objects.
    /// </summary>
    public enum ExpirationInterval
    {
        Milliseconds,
        Seconds,
        Minutes,
        Hours,
        Days
    }
}