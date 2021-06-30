using career.DTO.VacancyInformationDto;
using career.DTO.VacancyRequirementDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DTO.VacancyDTO
{
    public class VacancyDeleteDto
    {
        public int VacancyId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
