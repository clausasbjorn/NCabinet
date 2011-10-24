namespace NCabinet.Settings
{
    public interface IInitializationExpression
    {
        void UseProvider<T>() where T : ICacheProvider;
    }
}