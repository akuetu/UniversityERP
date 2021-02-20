using Enrollment.Model.Entities;
using Enrollment.Services;
using Enrollment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Enrollment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountyController : ControllerBase
    {
        private readonly ICrudService<County> _crudService;

        public CountyController(ICrudService<County> crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            return Ok(await _crudService.GetEntityList());
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(County county)
        {         
            return Ok(await _crudService.SaveEntity(county));
        }


        [HttpPost("delete")]
        public async Task<IActionResult> Delete(County county)
        {
            return Ok(await _crudService.DeleteEntity(county));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(County county)
        {
            return Ok(await _crudService.UpdateEntity(county));
        }

    }
}
