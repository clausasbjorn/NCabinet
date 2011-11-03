namespace NCabinet.Tests.Data
{
    public static class Mock
    {
        public static User GetDefaultUser()
        {
            return new User() { UserID = 1000000 };
        }

        public static User GetUser(int userID)
        {
            return new User() { UserID = userID };
        }
    }
}