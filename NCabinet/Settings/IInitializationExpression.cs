namespace NCabinet.Settings
{
    public interface IInitializationExpression
    {
        void UseProvider<T>(T provider) where T : ICacheProvider;
    }
}