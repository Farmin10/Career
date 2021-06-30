using career.DAL.Abstract;
using career.DAL.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.DataAccess.EntityFramework
{
    public class UnitOfwork : IUnitOfWork
    {
        CareerContext _context;
        public UnitOfwork(CareerContext context)
        {
            _context = context;
            VacancyDal = new EfVacancyDal(_context);
            VacancyInformationDal = new EfVacancyInformationDal(_context);
            VacancyRequirementDal = new EfVacancyRequirementDal(_context);
            VacancyTypeDal = new EfVacancyTypeDal(_context);
            PositionDal = new EfPositionDal(_context);
            EmployeeDal = new EfEmployeeDal(_context);
            DepartmantDal = new EfDepartmantDal(_context);
            UserDal = new EfUserDal(_context);
        }


        public IVacancyDal VacancyDal { get; private set; }

        public IVacancyInformationDal VacancyInformationDal { get; private set; }

        public IVacancyRequirementDal VacancyRequirementDal { get; private set; }

        public IVacancyTypeDal VacancyTypeDal { get; private set; }

        public IDepartmantDal DepartmantDal { get; private set; }

        public IEmployeeDal EmployeeDal { get; private set; }

        public IPositionDal PositionDal { get; private set; }

        public IUserDal UserDal { get; private set; }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
