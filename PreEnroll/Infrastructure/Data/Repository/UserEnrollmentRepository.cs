using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public FormEnrollmentModel GetFormEnrollment()
        {
            var formEnrollmentModel = new FormEnrollmentModel();

            using (var connection = GetDbconnection())
            {
                connection.Open();

                using var multi = connection.QueryMultipleAsync("Sp_GetFormEnrollment").Result;
                var countries = multi.Read<Country>().ToList();
                var counties = multi.Read<County>().ToList();
                var courses = multi.Read<Course>().ToList();
                var periods = multi.Read<Period>().ToList();
                var documentTypes = multi.Read<DocumentType>().ToList();
                var paymentTypes = multi.Read<PaymentType>().ToList();


                formEnrollmentModel.Countries = countries;
                formEnrollmentModel.Counties = counties;
                formEnrollmentModel.Courses = courses;
                formEnrollmentModel.Periods = periods;
                formEnrollmentModel.DocumentTypes = documentTypes;
                formEnrollmentModel.PaymentTypes = paymentTypes;
            }

            return formEnrollmentModel;
        }
    }
}
