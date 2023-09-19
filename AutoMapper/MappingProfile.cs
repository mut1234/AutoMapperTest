

using AutoMapper;
using AutoMapperTest.Dtos;
using AutoMapperTest.Models;

namespace AutoMapperTest
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<book, BookDto>().ForMember(d => d.Id, s => s.MapFrom(s=>s.BookId))//s = source ,d = destination
            .ForMember(d => d.IsFree, s => s.MapFrom(s=>s.Price == 0)).ReverseMap();
        }

    }
}
