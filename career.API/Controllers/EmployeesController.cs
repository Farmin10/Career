using career.BLL.Abstract;
using career.DTO.EmployeeDTO;
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
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        /// <summary>
        /// isci siyahisi
        /// </summary>
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _employeeService.GetAll();
            return Ok(result);
        }


        /// <summary>
        /// isci elave etme
        /// </summary>
        /// <param name="employeeAddDto"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult AddEmployee(EmployeeAddDto employeeAddDto)
        {
            var result = _employeeService.AddEmployee(employeeAddDto);
            return Ok(result);
        }


        /// <summary>
        /// isci yenileme
        /// </summary>
        /// <param name="updateEmployeeDto"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public IActionResult UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            var result = _employeeService.UpdateEmployee(updateEmployeeDto);
            return Ok(result);
        }



        /// <summary>
        /// isci silme
        /// </summary>
        /// <param name="updateEmployeeDto"></param>
        /// <returns></returns>
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
            return Ok();
        }
    }
}
