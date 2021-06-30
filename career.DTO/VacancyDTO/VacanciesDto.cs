using career.DTO.VacancyInformationDto;
using career.DTO.VacancyRequirementDto;
using career.DTO.VacancyTypeDTO;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DTO.VacancyDTO
{
    public class VacanciesDto
    {
        public int VacancyId { get; set; }
        public VacancyTypeDto VacancyTypeDto { get; set; }
        public string VacancyHeader { get; set; }
        public string WorkLocation { get; set; }
        public string RequiredExperience { get; set; }
        public string Education { get; set; }
        public string RelativePerson { get; set; }
        public int MinimumAgeLimit { get; set; }
        public int MaximumAgeLimit { get; set; }

        public DateTime VacancyStartDate { get; set; }

        public DateTime VacancyEndDate { get; set; }

        public List<VacancyInformationGetDto> VacancyInformationGetDtos { get; set; }
        public List<VacancyRequirementGetDto> VacancyRequirementGetDtos { get; set; }
        
    }
}
