using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Enrollment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICrudService<Course> _crudService;

        public CourseController(ICrudService<Course> crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            return Ok(await _crudService.GetEntityList());
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(Course course)
        {
            return Ok(await _crudService.SaveEntity(course));
        }


        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Course course)
        {
            return Ok(await _crudService.DeleteEntity(course));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Course course)
        {
            return Ok(await _crudService.UpdateEntity(course));
        }

    }
}
