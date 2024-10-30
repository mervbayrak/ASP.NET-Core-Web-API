using System;
using bsStoreApp.Entities.RequestFeatures;
using Microsoft.AspNetCore.Http;

namespace bsStoreApp.Entities.DataTransferObjects
{
	public class LinkParameters
	{
        public BookParameters BookParameters { get; init; }
        public HttpContext HttpContext { get; init; }
    }
}

