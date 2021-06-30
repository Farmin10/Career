using career.DAL.Abstract;
using career.DAL.DataAccess.EntityFramework;
using career.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.Concrete.EntityFramework
{
    public class EfVacancyDal:EfEntityRepositoryBase<Vacancy>,IVacancyDal
    {
        CareerContext _context;

        public EfVacancyDal(CareerContext context) : base(context)
        {
            _context = context;
        }

        public Vacancy DeleteVacancy(Vacancy vacancy)
        {
             return _context.Vacancies.Include(x => x.VacancyType).Include(x => x.VacancyInformation).Include(x => x.VacancyRequirements).SingleOrDefault(x => x.VacancyId == vacancy.VacancyId);
        }

        public List<Vacancy> GetVacancies()
        {
            return _context.Vacancies.Include(x => x.VacancyType).Include(x=>x.VacancyInformation).Include(x=>x.VacancyRequirements).ToList();
        }

        public Vacancy GetVacancyById(int id)
        {
            return _context.Vacancies.Include(x => x.VacancyType).Include(x => x.VacancyInformation).Include(x => x.VacancyRequirements).SingleOrDefault(x => x.VacancyId == id);
        }
    }
}
