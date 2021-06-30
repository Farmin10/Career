using career.BLL.Abstract;
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
    public class DepartmantsController : ControllerBase
    {
        IDepartmantService _departmantService;

        public DepartmantsController(IDepartmantService departmantService)
        {
            _departmantService = departmantService;
        }

        /// <summary>
        /// departmant siyahisi
        /// </summary>
        [HttpGet("getall")]
        public IActionResult GetDepartmants()
        {
            var result = _departmantService.GetAll();
            return Ok(result);
        }
    }
}
