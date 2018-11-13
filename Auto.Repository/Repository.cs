namespace Auto.Repository
{
    public class Repository
    {
        protected string connectionString;

        protected Repository(string connectionStr)
        {
            connectionString = connectionStr;
        }
    }
}
