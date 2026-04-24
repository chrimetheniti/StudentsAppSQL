using AutoMapper;
using StudentsAppSQL.Models;
using StudentsAppSQL.DTO;

namespace StudentsAppSQL.Configuration
{
    public class MapperConfig : Profile
    {

        public MapperConfig()
        {
            CreateMap<StudentInsertDTO, Student>().ReverseMap();
            CreateMap<StudentUpdateDTO, Student>().ReverseMap();
            CreateMap<StudentReadOnlyDTO, Student>().ReverseMap();
        }
    }
}
