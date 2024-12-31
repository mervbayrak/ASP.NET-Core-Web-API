using System;
using bsStoreApp.Entities.DataTransferObjects;
using Microsoft.AspNetCore.Identity;

namespace bsStoreApp.Services.Contract
{
	public interface IAuthenticationService
	{
		Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto);
		Task<bool> ValidateUser(UserForAuthenticationDto userForAuthenticationDto);
		Task<TokenDto> CreateToken(bool populateExp);
		Task<TokenDto> RefreshToken(TokenDto tokenDto);
    }
}

