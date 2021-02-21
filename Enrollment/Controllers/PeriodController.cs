using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enrollment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodController : ControllerBase
    {
        private readonly ICrudService<Period> _crudService;

        public PeriodController(ICrudService<Period> crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            return Ok(await _crudService.GetEntityList());
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(Period period)
        {
            return Ok(await _crudService.SaveEntity(period));
        }


        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Period period)
        {
            return Ok(await _crudService.DeleteEntity(period));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Period period)
        {
            return Ok(await _crudService.UpdateEntity(period));
        }

    }
}
