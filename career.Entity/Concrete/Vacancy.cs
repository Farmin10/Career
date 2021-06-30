using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.Entity.Concrete
{
    public class Vacancy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacancyId { get; set; }
        public int VacancyTypeId { get; set; }
        public VacancyType VacancyType { get; set; }
        public string VacancyHeader { get; set; }
        public string  WorkLocation { get; set; }
        public string  RequiredExperience { get; set; }
        public string  Education { get; set; }
        public string  RelativePerson { get; set; }
        public int MinimumAgeLimit { get; set; }
        public int MaximumAgeLimit { get; set; }

        public DateTime VacancyStartDate { get; set; }

        public DateTime VacancyEndDate { get; set; }
        public bool IsDeleted { get; set; }

        public List<VacancyInformation> VacancyInformation { get; set; }
        public List<VacancyRequirement> VacancyRequirements { get; set; }
    }
}
