using Enrollment.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreEnroll.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> SaveUser(User user);
        Task<IEnumerable<User>> ListAllUser();
    }
}
