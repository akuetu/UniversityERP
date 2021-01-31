using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Threading.Tasks;

namespace Enrollment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IUserEnrollmentService _userEnrollmentService;

        public EnrollmentController(IUserEnrollmentService userEnrollmentService)
        {
            _userEnrollmentService = userEnrollmentService;
        }


        [HttpGet]
        public async Task<IActionResult> GetEnrollmentsAsync()
        {
            var enrollments = await _userEnrollmentService.GetEnrollment();
            return Ok(enrollments);
        }

        [HttpPost]
        public async Task<IActionResult> SaveEnrollments(UserEnrollment userEnrollment)
        {
            //add obj validation
            if (userEnrollment == null) return NotFound();

            var enrollments = await _userEnrollmentService.SaveEnrollment(userEnrollment);
            return Ok(enrollments);
        }
    }
}
