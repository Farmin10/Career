using career.DTO.VacancyInformationDto;
using career.DTO.VacancyRequirementDto;
using career.DTO.VacancyTypeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DTO.VacancyDTO
{
    public class VacancyAddDto
    {
        public int VacancyTypeId { get; set; }
        public string VacancyHeader { get; set; }
        public string WorkLocation { get; set; }
        public string RequiredExperience { get; set; }
        public string Education { get; set; }
        public string RelativePerson { get; set; }
        public int MinimumAgeLimit { get; set; }
        public int MaximumAgeLimit { get; set; }

        public DateTime VacancyStartDate { get; set; }

        public DateTime VacancyEndDate { get; set; }

        public List<VacancyInformationAddDto> VacancyInformationAddDto { get; set; }
        
        public List<VacancyRequirementAddDto> VacancyRequirementAddDtos { get; set; }
    }
}
