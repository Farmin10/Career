using career.BLL.Abstract;
using career.DTO.VacancyDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace career.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    public class VacancyTypesController : ControllerBase
    {
        IVacancyTypeService _vacancyTypeService;

        public VacancyTypesController(IVacancyTypeService vacancyTypeService)
        {
            _vacancyTypeService = vacancyTypeService;
        }


        /// <summary>
        /// Get all data
        /// </summary>
        /// <returns></returns>
        [HttpGet("Getall")]
        public IActionResult GetAll()
        {
            var result = _vacancyTypeService.GetAll();
            return Ok(result);
        }



        
    }
}
