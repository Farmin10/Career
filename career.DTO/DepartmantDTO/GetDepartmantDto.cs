using career.DTO.EmployeeDTO;
using career.DTO.PositionDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DTO.DepartmantDTO
{
    public class GetDepartmantDto
    {
        public int DepartmantId { get; set; }
        public string Name { get; set; }
        public List<GetPositionDto> GetPositionsDtos { get; set; }
        public List<GetEmployeeDto> GetGetEmployeeDtos { get; set; }
    }
}
