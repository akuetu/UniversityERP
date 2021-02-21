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
    public class UserController : ControllerBase
    {
        private readonly ICrudService<User> _crudService;

        public UserController(ICrudService<User> crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            return Ok(await _crudService.GetEntityList());
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(User user)
        {
            return Ok(await _crudService.SaveEntity(user));
        }


        [HttpPost("delete")]
        public async Task<IActionResult> Delete(User user)
        {
            return Ok(await _crudService.DeleteEntity(user));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(User user)
        {
            return Ok(await _crudService.UpdateEntity(user));
        }

    }
}
