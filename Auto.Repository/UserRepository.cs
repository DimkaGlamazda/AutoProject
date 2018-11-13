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


        private const string ConnectionStr 
            = "Data Source=DIMA\\SQLEXPRESS;Initial Catalog=Auto;Integrated Security=true;";


        public void Add(DomainUser user)
        {
            SqlUser _user = user.ToSql();

            string queryStr = 
                $"INSERT INTO {_userTableStr}" +
                $" (Name, LastName, Email, Password, Type) VALUES" +
                $" ('{_user.Name.ToString()}', '{user.LastName.ToString()}', '{user.Email.ToString()}'," +
                $" '{user.Password.ToString()}', {user.Type})";

            using (var con = new SqlConnection(ConnectionStr))
            {
                con.Query(queryStr).FirstOrDefault();
            }
        }

    }
}
