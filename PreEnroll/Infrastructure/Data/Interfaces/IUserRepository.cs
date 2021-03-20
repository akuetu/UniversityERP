using Enrollment.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreEnroll.Infrastructure.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User> SaveUser(User user);
        Task<IEnumerable<User>> ListAllUser();
    }
}
