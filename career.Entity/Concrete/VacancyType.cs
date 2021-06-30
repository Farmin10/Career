using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.Entity.Concrete
{
    public class VacancyType
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacancyTypeId { get; set; }
        public string Key { get; set; }
        [Required]
        public string  Name { get; set; }
        public bool IsDeleted { get; set; }

        public List<Vacancy> Vacancies { get; set; }
    }
}
