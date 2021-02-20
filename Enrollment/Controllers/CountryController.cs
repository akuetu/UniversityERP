using Enrollment.Model.Entities;
using Enrollment.Services;
using Enrollment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Enrollment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICrudService<Country> _crudService;

        public CountryController(ICrudService<Country> crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            return Ok(await _crudService.GetEntityList());
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(Country country)
        {         
            return Ok(await _crudService.SaveEntity(country));
        }


        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Country country)
        {
            return Ok(await _crudService.DeleteEntity(country));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Country country)
        {
            return Ok(await _crudService.UpdateEntity(country));
        }

    }
}
