using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Enrollment.Infrastructure.Data.Base;
using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Model.Entities;
using Microsoft.Extensions.Configuration;
using PreEnroll.Model.Entities;

namespace Enrollment.Infrastructure.Data.Repository
{
    public class UserEnrollmentRepository: BaseRepository<UserEnrollment>, IUserEnrollmentRepository
    {
   
        public UserEnrollmentRepository(IConfiguration config) :base(config) { }


        public async Task<IEnumerable<UserEnrollment>> GetEnrollment()
        {
            return await GetAll<UserEnrollment>("GetAllUserEnrollment", null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<EnrollmentViewModel>> GetAllEnrollment()
        {
            return await GetAll<EnrollmentViewModel>("Sp_GetAllEnrollment", null, commandType: CommandType.StoredProcedure);
        }

        public async Task<UserEnrollment> SaveEnrollment(UserEnrollment enrollment)
        {
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@UserId", enrollment.UserId);
            parameter.Add("@DocumentTypeId", enrollment.DocumentTypeId);
            parameter.Add("@CountyId", enrollment.CountyId);
            parameter.Add("@CountryId", enrollment.CountryId);
            parameter.Add("@PaymentTypeId", enrollment.PaymentTypeId);
            parameter.Add("@PathTypeDocument", enrollment.PathTypeDocument);
            parameter.Add("@PathTypePayment", enrollment.PathTypePayment);
            parameter.Add("@Note", enrollment.Note);
            return  await Insert<UserEnrollment>("SP_SaveUserEnrollment", parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
