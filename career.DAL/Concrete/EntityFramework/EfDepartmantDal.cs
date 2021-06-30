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
    public class EfDepartmantDal : EfEntityRepositoryBase<Departmant>, IDepartmantDal
    {
        CareerContext _context;

        public EfDepartmantDal(CareerContext context) : base(context)
        {
            _context = context;
        }

        public List<Departmant> GetAll()
        {
            return _context.Departmants.Include(x => x.Employees).Include(p => p.Positions).ToList();
        }
    }
}
