using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.Entity.Concrete
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        public string  SurName { get; set; }
        [Required]
        public string  PhoneNumber { get; set; }
        [Required]
        public string  Email { get; set; }
        public int? DepartmantId { get; set; }
        public Departmant Departmant { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 7)]
        public string  Pin { get; set; }
        public bool IsDeleted { get; set; }
    }
}
