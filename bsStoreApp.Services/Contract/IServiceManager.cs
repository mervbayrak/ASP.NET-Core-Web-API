using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsStoreApp.Services.Contract
{
    public interface IServiceManager
    {
        IBookServices BookServices { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
