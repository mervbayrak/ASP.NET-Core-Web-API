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
        private readonly IBookServices _bookServices;
        private readonly IAuthenticationService _authenticationService;

        public ServiceManager(IBookServices bookServices, IAuthenticationService authenticationService)
        {
            _bookServices = bookServices;
            _authenticationService = authenticationService;
        }

        public IBookServices BookServices => _bookServices;
        public IAuthenticationService AuthenticationService => _authenticationService;
    }
}
