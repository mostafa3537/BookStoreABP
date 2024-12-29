using AutoMapper;
using BookStoreABP.Books;

namespace BookStoreABP;

public class BookStoreABPApplicationAutoMapperProfile : Profile
{
    public BookStoreABPApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
