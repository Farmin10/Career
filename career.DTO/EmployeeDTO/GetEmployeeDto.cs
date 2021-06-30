using career.DTO.DepartmantDTO;
using career.DTO.PositionDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DTO.EmployeeDTO
{
    public class GetEmployeeDto
    {
        
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Pin { get; set; }
        public GetDepartmantForEmployeeDto Departmant { get; set; }
        public GetPositionForEmployeeDto Position { get; set; }
    }
}
