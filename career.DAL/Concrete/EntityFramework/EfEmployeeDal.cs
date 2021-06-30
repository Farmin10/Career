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
    public class EfEmployeeDal:EfEntityRepositoryBase<Employee>, IEmployeeDal
    {
        CareerContext _context;

        public EfEmployeeDal(CareerContext context) : base(context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.Include(x => x.Position).Where(x=>x.DepartmantId==x.Departmant.DepartmantId).Include(p => p.Departmant).Where(x=>x.DepartmantId==x.Position.DepartmantId).ToList();
        }
    }
}
