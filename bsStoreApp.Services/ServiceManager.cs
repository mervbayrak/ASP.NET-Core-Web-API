using AutoMapper;
using bsStoreApp.Entities.DataTransferObjects;
using bsStoreApp.Entities.Models;
using bsStoreApp.Repositories.Contracts;
using bsStoreApp.Services.Contract;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
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
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(
            IRepositoryManager repositoryManager,
            ILoggerService logger,
            IMapper mapper,
            IBookLinks bookLinks,
            UserManager<User> userManager,
            IConfiguration configuration
            )
        {

            _bookServices = new Lazy<IBookServices>(() => new BookManager(repositoryManager, logger, mapper, bookLinks));

            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationManager(logger, mapper, userManager, configuration));
        }


        public IBookServices BookServices => _bookServices.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
