using System;
using BookStoreABP.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BookStoreABP.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = BookStoreABPPermissions.Books.Default;
        GetListPolicyName = BookStoreABPPermissions.Books.Default;
        CreatePolicyName = BookStoreABPPermissions.Books.Create;
        UpdatePolicyName = BookStoreABPPermissions.Books.Edit;
        DeletePolicyName = BookStoreABPPermissions.Books.Delete;
    }
}