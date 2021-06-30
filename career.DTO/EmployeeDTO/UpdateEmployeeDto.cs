using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DTO.EmployeeDTO
{
    public class UpdateEmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? DepartmantId { get; set; }
        public int PositionId { get; set; }
        public string Pin { get; set; }
    }
}
