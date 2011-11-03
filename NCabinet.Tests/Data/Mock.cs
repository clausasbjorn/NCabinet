namespace NCabinet.Tests.Data
{
    public static class Mock
    {
        public static User GetUser(int userID)
        {
            return new User() { UserID = userID };
        }
    }
}