using AutoMapper;
using career.DTO.DepartmantDTO;
using career.DTO.EmployeeDTO;
using career.DTO.PositionDTO;
using career.DTO.VacancyDTO;
using career.DTO.VacancyInformationDto;
using career.DTO.VacancyRequirementDto;
using career.DTO.VacancyTypeDTO;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.Mappings
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<VacancyType, VacancyTypesDTO>().ReverseMap();
            CreateMap<VacancyType, VacancyTypeAddDto>().ReverseMap();
            CreateMap<VacancyType, VacancyTypeDto>().ReverseMap();



            CreateMap<Departmant, GetDepartmantDto>().ReverseMap();
            CreateMap<Departmant, GetDepartmantForEmployeeDto>().ReverseMap();



            CreateMap<Position, GetPositionDto>().ReverseMap();
            CreateMap<Position, GetPositionForEmployeeDto>().ReverseMap();



            CreateMap<Employee, GetEmployeeDto>().ReverseMap();
            CreateMap<Employee, EmployeeAddDto>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeDto>().ReverseMap();



            CreateMap<Vacancy, VacancyUpdateDto>().ReverseMap();
            CreateMap<Vacancy, VacancyAddDto>().ReverseMap();
            CreateMap<Vacancy, VacanciesDto>().ReverseMap();
            CreateMap<Vacancy, VacancyDeleteDto>().ReverseMap();
            



            CreateMap<VacancyInformation, VacancyInformationUpdateDto>().ReverseMap();
            CreateMap<VacancyInformation, VacancyInformationAddDto>().ReverseMap();
            CreateMap<VacancyInformation, VacancyInformationGetDto>().ReverseMap();
            CreateMap<VacancyInformation, VacancyInformationDeleteDto>().ReverseMap();


            CreateMap<VacancyRequirement, VacancyRequirementUpdateDto>().ReverseMap();
            CreateMap<VacancyRequirement, VacancyRequirementAddDto>().ReverseMap();
            CreateMap<VacancyRequirement, VacancyRequirementGetDto>().ReverseMap();
            CreateMap<VacancyRequirement, VacancyRequirementDeleteDto>().ReverseMap();
        }
    }
}
