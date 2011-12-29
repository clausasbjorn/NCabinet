namespace NCabinet
{
    /// <summary>
    /// Callback used for the weakly typed get method.
    /// </summary>
    /// <typeparam name="T">The type of the cached object</typeparam>
    /// <param name="values">The parameters/keys used by the callback</param>
    /// <returns>A cached item of type T</returns>
    public delegate T Callback<T>(params object[] values);
}