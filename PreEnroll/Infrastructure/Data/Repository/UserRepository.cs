using Dapper;
using Enrollment.Infrastructure.Data.Base;
using Enrollment.Model.Entities;
using Microsoft.Extensions.Configuration;
using PreEnroll.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PreEnroll.Infrastructure.Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration config) : base(config) { }


        public async Task<IEnumerable<User>> ListAllUser()
        {
            return await GetAll<User>("GetAllCountries", null, commandType: CommandType.StoredProcedure);
        }

        public async Task<User> SaveUser(User user)
        {           
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@Name", user.Name);
            parameter.Add("@Name", user.Name);
            parameter.Add("@Telephone", user.Telephone);
            parameter.Add("@Address", user.Address);
            parameter.Add("@HasDisability", user.HasDisability); 

            return await Insert<User>("SP_SaveUser", parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
