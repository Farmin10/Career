using career.DTO.VacancyDTO;
using career.DTO.VacancyTypeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Abstract
{
    public interface IVacancyTypeService
    {
        List<VacancyTypesDTO> GetAll();
        
    }
}
