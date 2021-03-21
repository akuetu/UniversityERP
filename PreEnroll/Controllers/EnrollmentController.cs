using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PreEnroll.Services.Interfaces;
using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;

namespace PreEnroll.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IUserEnrollmentService userEnrollmentService;

        public EnrollmentController(IUserService userService, IUserEnrollmentService userEnrollmentService)
        {
            this.userService = userService;
            this.userEnrollmentService = userEnrollmentService;
        }


        [HttpGet("getuser")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await userService.ListAllUser());
        }

        [HttpGet("getuserEnrollment")]
        public async Task<IActionResult> GetUserEnrollment()
        {
            return Ok(await userEnrollmentService.GetEnrollment());
        }

        [HttpGet("getalluserEnrollment")]
        public async Task<IActionResult> GetAllUserEnrollment()
        {
            return Ok(await userEnrollmentService.GetAllEnrollment());
        }

        [HttpGet("getformEnrollment")]
        public IActionResult GetFormEnrollment()
        {
            return Ok( userEnrollmentService.GetFormEnrollment());
        }


        [HttpPost("saveuser")]
        public async Task<IActionResult> PostUser(User user)
        {
            return Ok(await userService.SaveUser(user));
        }

        [HttpPost("saveUserEnrollment")]
        public async Task<IActionResult> PostUserEnrollment(UserEnrollment userEnrollment)
        {
            return Ok(await userEnrollmentService.SaveEnrollment(userEnrollment));
        }
    }
}
