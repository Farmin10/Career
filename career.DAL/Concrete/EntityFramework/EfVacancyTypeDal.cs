using AutoMapper;
using career.DAL.Abstract;
using career.DAL.DataAccess.EntityFramework;
using career.DTO.VacancyTypeDTO;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.Concrete.EntityFramework
{
    public class EfVacancyTypeDal : EfEntityRepositoryBase<VacancyType>, IVacancyTypeDal
    {
        CareerContext _context;

        public EfVacancyTypeDal(CareerContext context) : base(context)
        {
            _context = context;
        }

        //public List<VacancyTypesDTO> GetAll()
        //{
        //    var result = _context.VacancyTypes.ToList();
        //    //var mappedEntity= _mapper.Map<VacancyTypesDTO>(result);
        //    return result.ToList();
        //}
    }
}
