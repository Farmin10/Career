using career.DAL.DataAccess;
using career.DTO.VacancyTypeDTO;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.Abstract
{
    public interface IVacancyTypeDal : IEntityRepository<VacancyType>
    {
        //List<VacancyTypesDTO> GetAll();
    }
}
