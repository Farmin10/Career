using AutoMapper;
using career.BLL.Abstract;
using career.DAL.DataAccess;
using career.DTO.VacancyDTO;
using career.DTO.VacancyTypeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Concrete
{
    public class VacancyTypeManager : IVacancyTypeService
    {
        IMapper _mapper;
        IUnitOfWork _unitOfWork;
        public VacancyTypeManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        

        public List<VacancyTypesDTO> GetAll()
        {
            var result= _unitOfWork.VacancyTypeDal.Get();
            var mappedEntity = _mapper.Map<List<VacancyTypesDTO>>(result);
            return mappedEntity;
        }
    }
}
