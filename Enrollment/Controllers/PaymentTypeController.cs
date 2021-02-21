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
    public class PaymentTypeController : ControllerBase
    {
        private readonly ICrudService<PaymentType> _crudService;

        public PaymentTypeController(ICrudService<PaymentType> crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            return Ok(await _crudService.GetEntityList());
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(PaymentType paymentType)
        {
            return Ok(await _crudService.SaveEntity(paymentType));
        }


        [HttpPost("delete")]
        public async Task<IActionResult> Delete(PaymentType paymentType)
        {
            return Ok(await _crudService.DeleteEntity(paymentType));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(PaymentType paymentType)
        {
            return Ok(await _crudService.UpdateEntity(paymentType));
        }

    }
}
