using AutoMapper;
using bsStoreApp.Entities.DataTransferObjects;
using bsStoreApp.Entities.Models;

namespace bsStoreApp.WebApi.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDtoForUpdate, Book>().ReverseMap();
            CreateMap<Book, BookDto>();
            CreateMap<BookDtoForInsertion, Book>();
        }
    }
}
