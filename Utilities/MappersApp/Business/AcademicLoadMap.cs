using AutoMapper;
using Entity.Dtos.Business.AcademicLoad;
using Entity.Enum;
using Entity.Model.Business;
using Utilities.helpers;
using DaysFlags = Entity.Enum.Days;

namespace Utilities.MappersApp.Business
{
    public class AcademicLoadMap : Profile
    {
        public AcademicLoadMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<AcademicLoad, AcademicLoadDto>().ReverseMap();

            CreateMap<AcademicLoad, AcademicLoadReadDto>()
            .ForMember(d => d.Days, o => o.MapFrom(s =>
                ((DaysFlags)(s.Days ?? 0)).ToTexts().ToArray()
            ));
        }
    }
}