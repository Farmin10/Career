using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.Entity.Concrete
{
    public class Departmant
    {
        public int DepartmantId { get; set; }
        [Required]
        public string  Name { get; set; }
        public Departmant ParentDepartmant { get; set; }
        [ForeignKey("Departmant")]
        public int? ParentDepartmantId { get; set; }
        public bool IsDeleted { get; set; }

        public List<Position> Positions { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
