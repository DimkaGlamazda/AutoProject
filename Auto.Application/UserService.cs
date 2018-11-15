using ContractUser = Auto.Contract.User;
using DomainUser = Auto.Domain.User;
using Auto.Repository;
using Auto.Mapper;

namespace Auto.Application
{
    public class UserService
    {
        private Repository.Repository _repository;

        public UserService(string connection)
        {

            ///"Data Source = DIMA\\SQLEXPRESS; Initial Catalog = Auto; Integrated Security = true;"
            _repository = new Repository.UserRepository(connection);
        }

           
        public void Add(ContractUser user)
        {
            DomainUser domainUser = user.ToDomain();
            domainUser.Type = 1;
            _repository.Create(domainUser);
        }
    }
}
