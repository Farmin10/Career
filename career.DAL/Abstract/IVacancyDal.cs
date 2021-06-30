using career.DAL.DataAccess;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.Abstract
{
    public interface IVacancyDal:IEntityRepository<Vacancy>
    {
        List<Vacancy> GetVacancies();
        Vacancy GetVacancyById(int id);
        Vacancy DeleteVacancy(Vacancy vacancy);
    }
}
