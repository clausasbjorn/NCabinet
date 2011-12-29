namespace NCabinet.Settings
{
    /// <summary>
    /// The interface an object must adhere to in order to be able be
    /// set up using the initialization expression.
    /// </summary>
    public interface IInitializationExpression
    {
        void UseProvider<T>(T provider) where T : ICacheProvider;
    }
}