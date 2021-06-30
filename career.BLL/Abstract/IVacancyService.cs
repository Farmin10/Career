using career.DTO.VacancyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Abstract
{
    public interface IVacancyService
    {
        List<VacanciesDto> GetVacancies();
        VacanciesDto GetVacancyById(int id);
        VacancyAddDto AddVacancy(VacancyAddDto vacancyAddDto);
        VacancyUpdateDto UpdateVacancy(VacancyUpdateDto vacancyUpdateDto);
        void DeleteVacancy(int id);
    }
}
