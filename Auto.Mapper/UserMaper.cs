using System.Collections.Generic;
using System.Linq;
using DomainUser = Auto.Domain.User;
using SqlUser = Auto.Sql.User;
using ContractUser = Auto.Contract.User;

namespace Auto.Mapper
{
    public static class UserMaper
    {
        public static SqlUser ToSql(this DomainUser model)
        {
            return new SqlUser
            {
                Id = model.Id,
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password,
                Type = model.Type
            };
        }

        public static ICollection<SqlUser> ToSql(this ICollection<DomainUser> models)
        {
            return models.Select(m => m.ToSql()).ToList();
        }

        public static DomainUser ToDomain(this SqlUser model)
        {
            return new DomainUser
            {
                Id = model.Id,
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password,
                Type = model.Type
            };
        }

        public static ICollection<DomainUser>ToDomain(this ICollection<SqlUser> models)
        {
            return models.Select(m => m.ToDomain()).ToList();
        }

        public static DomainUser ToDomain(this ContractUser model)
        {
            return new DomainUser
            {
                Id = model.Id,
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password
            };
        }

        public static ICollection<DomainUser> ToDomain(this ICollection<ContractUser> models)
        {
            return models.Select(m => m.ToDomain()).ToList();
        }

        public static ContractUser ToContract(this DomainUser model)
        {
            return new ContractUser
            {
                Id = model.Id,
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password
            };
        }

        public static ICollection<ContractUser> ToContract(this ICollection<DomainUser> models)
        {
            return models.Select(m => m.ToContract()).ToList();
        }
    }
}