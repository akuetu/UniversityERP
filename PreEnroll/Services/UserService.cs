using Enrollment.Model.Entities;
using PreEnroll.Infrastructure.Data.Interfaces;
using PreEnroll.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreEnroll.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> ListAllUser()
        {
            return await userRepository.ListAllUser();
        }

        public async Task<User> SaveUser(User user)
        {
            return await userRepository.SaveUser(user);
        }
    }
}
