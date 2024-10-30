using System;
using bsStoreApp.Entities.DataTransferObjects;
using bsStoreApp.Entities.LinkModels;
using Microsoft.AspNetCore.Http;

namespace bsStoreApp.Services.Contract
{
	public interface IBookLinks
	{
        LinkResponse TryGenerateLinks(IEnumerable<BookDto> booksDto, string fields, HttpContext httpContext);
    }
}

