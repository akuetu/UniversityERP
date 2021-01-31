﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Enrollment.Model.Entities;

namespace Enrollment.Infrastructure.Data.Interfaces
{
    public interface IUserEnrollmentRepository
    {
        Task<List<UserEnrollment>> GetEnrollment();
        Task SaveEnrollment(UserEnrollment enrollment);
    }
}
