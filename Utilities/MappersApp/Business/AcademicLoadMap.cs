using AutoMapper;
using Entity.Dtos.Business.AcademicLoad;
using Entity.Dtos.Business.DataBasic;
using Entity.Model.Business;

namespace Utilities.MappersApp.Business
{
    public class AcademicLoadMap : Profile
    {
        public AcademicLoadMap()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<AcademicLoad, AcademicLoadDto>().ReverseMap();
        }
    }
}