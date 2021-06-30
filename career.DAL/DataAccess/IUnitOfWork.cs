using career.DAL.Abstract;
using career.DAL.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.DataAccess
{
    public interface IUnitOfWork:IDisposable
    {
        IVacancyDal VacancyDal { get; }
        IVacancyInformationDal VacancyInformationDal { get; }
        IVacancyRequirementDal VacancyRequirementDal { get; }
        IVacancyTypeDal VacancyTypeDal { get; }
        IDepartmantDal DepartmantDal { get; }
        IEmployeeDal EmployeeDal { get; }
        IPositionDal PositionDal { get; }
        IUserDal UserDal { get; }


        void Commit();
    }
}
