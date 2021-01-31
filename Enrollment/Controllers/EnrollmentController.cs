using Microsoft.AspNetCore.Mvc;

namespace Enrollment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEnrollmentForm()
        {
            //
            return Ok("ok");
        }
    }
}
