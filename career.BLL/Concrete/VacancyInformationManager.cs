using AutoMapper;
using career.BLL.Abstract;
using career.DAL.DataAccess;
using career.DTO.VacancyInformationDto;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Concrete
{
    public class VacancyInformationManager : IVacancyInformationService
    {
        IMapper _mapper;
        IUnitOfWork _unitOfWork;
        public VacancyInformationManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        //public void AddVacancyInformation(List<VacancyInformationAddDto> vacancyInformationAddDto)
        //{
        //    var mappedInformation = _mapper.Map<List<VacancyInformation>>(vacancyInformationAddDto);
        //    foreach (var item in vacancyInformationAddDto)
        //    {
        //        var vacancy = _unitOfWork.VacancyDal.Get().FirstOrDefault(a => a.VacancyId == item.VacancyId);
        //        if (vacancy!=null)
        //        {
        //            vacancy.VacancyId = item.VacancyId;

        //            _unitOfWork.VacancyInformationDal.AddRange(mappedInformation);
        //            _unitOfWork.Commit();
        //        }
               
        //    }
            
        //}

        
    }
}
