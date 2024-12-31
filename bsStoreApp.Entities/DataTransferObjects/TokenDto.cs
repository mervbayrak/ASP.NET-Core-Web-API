using System;
namespace bsStoreApp.Entities.DataTransferObjects
{
	public record TokenDto
	{
		public String AccessToken { get; init; }
		public String RefreshToken { get; init; }

    }
}

