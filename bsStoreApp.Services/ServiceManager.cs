using AutoMapper;
using bsStoreApp.Entities.DataTransferObjects;
using bsStoreApp.Repositories.Contracts;
using bsStoreApp.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsStoreApp.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBookServices> _bookServices;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerService logger, IMapper mapper, IDataShaper<BookDto> shaper)
        {
            _bookServices = new Lazy<IBookServices>(()=> new BookManager(repositoryManager, logger, mapper));
        }
        public IBookServices BookServices => _bookServices.Value;
    }
}
