using career.DTO.EmployeeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Abstract
{
    public interface IEmployeeService
    {
        List<GetEmployeeDto> GetAll();
        EmployeeAddDto AddEmployee(EmployeeAddDto employeeAddDto);
        UpdateEmployeeDto UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
        void DeleteEmployee(int id);
    }
}
