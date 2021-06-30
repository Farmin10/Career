using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.Entity.Concrete
{
    public class VacancyInformation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacancyInfoId { get; set; }
        public int VacancyId { get; set; }
        public Vacancy Vacancy { get; set; }
        public string  VacancyInfoLabel { get; set; }
        public string  VacancyInfoValue { get; set; }
        public bool IsDeleted { get; set; }
    }
}
