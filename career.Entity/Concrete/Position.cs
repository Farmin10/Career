using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.Entity.Concrete
{
    public class Position
    {
        public int PositionId { get; set; }
        [Required]
        public string  Name { get; set; }
        public Departmant Departmant { get; set; }
        public int? DepartmantId { get; set; }
        public bool IsDeleted { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
