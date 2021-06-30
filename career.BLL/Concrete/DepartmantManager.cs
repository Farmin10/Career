using AutoMapper;
using career.BLL.Abstract;
using career.DAL.DataAccess;
using career.DTO.DepartmantDTO;
using career.DTO.EmployeeDTO;
using career.DTO.PositionDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Concrete
{
    public class DepartmantManager : IDepartmantService
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DepartmantManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<GetDepartmantDto> GetAll()
        {
            var result = _unitOfWork.DepartmantDal.GetAll();
            
            var mappedDepartmant = _mapper.Map<List<GetDepartmantDto>>(result);
            foreach (var item in mappedDepartmant)
            {
                var employee = _unitOfWork.EmployeeDal.Get(x => x.DepartmantId == item.DepartmantId);
                var mappedPosition = _mapper.Map<List<GetPositionDto>>(item.GetPositionsDtos);
                var mappedEmployee = _mapper.Map<List<GetEmployeeDto>>(employee);
                mappedDepartmant.ForEach(x => x.GetPositionsDtos = mappedPosition );
                mappedDepartmant.ForEach(x => x.GetGetEmployeeDtos = mappedEmployee);
              
            }
           
            return mappedDepartmant;
        }
    }
}
