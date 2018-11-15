using DomainUser = Auto.Domain.User;

namespace Auto.Repository
{
    public abstract class Repository
    {
        protected string connectionString;

        protected Repository(string connectionStr)
        {
            connectionString = connectionStr;
        }

        public abstract void Create(DomainUser domain);
    }
}
