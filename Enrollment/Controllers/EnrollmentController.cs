using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

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
        public IActionResult GetEnrollments()
        {
            var enrollments = _userEnrollmentService.GetEnrollment();
            return Ok(enrollments);
        }

        [HttpPost]
        public IActionResult SaveEnrollments(UserEnrollment userEnrollment)
        {
            //add obj validation
            if (userEnrollment == null) return NotFound();

            var enrollments = _userEnrollmentService.SaveEnrollment(userEnrollment);
            return Ok(enrollments);
        }
    }
}
