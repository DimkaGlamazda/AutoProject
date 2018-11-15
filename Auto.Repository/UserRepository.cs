using Auto.Domain;
using Auto.Mapper;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using DomainUser = Auto.Domain.User;
using SqlUser = Auto.Sql.User;

namespace Auto.Repository
{
    public class UserRepository : Repository
    {
        public UserRepository(string connectionStr): base(connectionStr) {}


        private const string _userTableStr = "[Auto].[dbo].[User]";



        public override void Create(DomainUser domain)
        {
            SqlUser _user = domain.ToSql();

            string queryStr =
                $"INSERT INTO {_userTableStr}" +
                $" (Name, LastName, Email, Password, Type) VALUES" +
                $" ('{_user.Name.ToString()}', '{domain.LastName.ToString()}', '{domain.Email.ToString()}'," +
                $" '{domain.Password.ToString()}', {domain.Type})";

            using (var con = new SqlConnection(connectionString))
            {
                con.Query(queryStr).FirstOrDefault();
            }
        }
    }
}
