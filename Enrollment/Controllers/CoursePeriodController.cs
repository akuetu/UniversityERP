using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Enrollment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursePeriodController : ControllerBase
    {
        private readonly ICrudService<CoursePeriod> _crudService;

        public CoursePeriodController(ICrudService<CoursePeriod> crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            return Ok(await _crudService.GetEntityList());
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(CoursePeriod coursePeriod)
        {
            return Ok(await _crudService.SaveEntity(coursePeriod));
        }


        [HttpPost("delete")]
        public async Task<IActionResult> Delete(CoursePeriod coursePeriod)
        {
            return Ok(await _crudService.DeleteEntity(coursePeriod));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(CoursePeriod coursePeriod)
        {
            return Ok(await _crudService.UpdateEntity(coursePeriod));
        }

    }
}
