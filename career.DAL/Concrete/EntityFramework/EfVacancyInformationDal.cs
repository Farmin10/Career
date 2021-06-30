using career.DAL.Abstract;
using career.DAL.DataAccess;
using career.DAL.DataAccess.EntityFramework;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.Concrete.EntityFramework
{
    public class EfVacancyInformationDal : EfEntityRepositoryBase<VacancyInformation>, IVacancyInformationDal
    {
        CareerContext _context;
        public EfVacancyInformationDal(CareerContext context) : base(context)
        {
            _context = context;
        }
    }
}
