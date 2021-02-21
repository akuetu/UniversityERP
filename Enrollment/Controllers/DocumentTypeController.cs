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
    public class DocumentTypeController : ControllerBase
    {
        private readonly ICrudService<DocumentType> _crudService;

        public DocumentTypeController(ICrudService<DocumentType> crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            return Ok(await _crudService.GetEntityList());
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(DocumentType documentType)
        {
            return Ok(await _crudService.SaveEntity(documentType));
        }


        [HttpPost("delete")]
        public async Task<IActionResult> Delete(DocumentType documentType)
        {
            return Ok(await _crudService.DeleteEntity(documentType));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(DocumentType documentType)
        {
            return Ok(await _crudService.UpdateEntity(documentType));
        }

    }
}
