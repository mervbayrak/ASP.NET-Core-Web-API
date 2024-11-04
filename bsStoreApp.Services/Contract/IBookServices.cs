using bsStoreApp.Entities.DataTransferObjects;
using bsStoreApp.Entities.LinkModels;
using bsStoreApp.Entities.Models;
using bsStoreApp.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsStoreApp.Services.Contract
{
    public interface IBookServices
    {
        Task<(LinkResponse linkResponse, MetaData metaData)> GetAllBooksAsync(LinkParameters linkParameters, bool trackChanges);
        Task<BookDto> GetOneBookByIdAsync(int id, bool trackhanges);
        Task<BookDto> CreateOneBookAsync(BookDtoForInsertion book);
        Task UpdateOneBookAsync(int id, BookDtoForUpdate bookDto, bool trackChanges);
        Task DeleteOneBookAsync(int id, bool trackChanges);
        Task<(BookDtoForUpdate bookDtoForUpdate, Book book)> GetOneBookForPatchAsync(int id, bool trackChanges);
        Task SaveChangesForPatchAsync(BookDtoForUpdate bookDtoForUpdate, Book book);
        Task<List<Book>> GetAllBooksAsync(bool trackChanges);
    }
}
