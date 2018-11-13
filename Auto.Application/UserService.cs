using ContractUser = Auto.Contract.User;
using DomainUser = Auto.Domain.User;
using Auto.Repository;
using Auto.Mapper;

namespace Auto.Application
{
    public class UserService
    {
        private Repository.Repository _repository = new UserRepository("1111");

        public void Add(ContractUser user)
        {
            DomainUser domainUser = user.ToDomain();
            domainUser.Type = 1;
            _repository.Add(domainUser);
        }
    }
}
