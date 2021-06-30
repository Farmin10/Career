using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.Entity.Concrete
{
    public class VacancyRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacancyRequirementId { get; set; }
        public int VacancyId { get; set; }
        public Vacancy Vacancy { get; set; }
        public string RequirementPunct { get; set; }
         
        public bool IsDeleted { get; set; }
    }
}
