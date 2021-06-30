using career.BLL.Abstract;
using career.DTO.VacancyDTO;
using Microsoft.AspNetCore.Authorization;
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
    public class VacanciesController : ControllerBase
    {

        IVacancyService _vacancyService;

        public VacanciesController(IVacancyService vacancyService)
        {
            _vacancyService = vacancyService;
        }


        /// <summary>
        /// Butun vakansiyalar
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _vacancyService.GetVacancies();
            return Ok(result);
        }


        /// <summary>
        /// Id-ye gore vakansiya
        /// </summary>
        /// <returns></returns>
        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _vacancyService.GetVacancyById(id);
            return Ok(result);
        }

        /// <summary>
        /// Vakansiya elave et
        /// </summary>
        /// <param name="vacancyAddDto"></param>
        /// <returns></returns>
        [HttpPost("addVacancy")]
        public IActionResult AddVacancy(VacancyAddDto vacancyAddDto)
        {
            var result = _vacancyService.AddVacancy(vacancyAddDto);
            return Ok(result);
        }



        /// <summary>
        /// Vakansiya elave et
        /// </summary>
        /// <param name="vacancyAddDto"></param>
        /// <returns></returns>
        [HttpPut("updateVacancy")]
        public IActionResult UpdateVacancy(VacancyUpdateDto vacancyUpdateDto)
        {
            var result = _vacancyService.UpdateVacancy(vacancyUpdateDto);
            return Ok(result);
        }




        /// <summary>
        /// Vakansiyanin silinmesi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("deleteVacancy")]
        public IActionResult DeleteVacancy(int id)
        {
             _vacancyService.DeleteVacancy(id);
            return Ok();
        }
    }
}
