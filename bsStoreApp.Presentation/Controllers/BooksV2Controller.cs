using System;
using bsStoreApp.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace bsStoreApp.Presentation.Controllers
{
	//[ApiVersion("2.0", Deprecated = true)]
	[ApiController]
    [Route("api/books")]

    //[Route("api/v:{apiversion}/books")]
    public class BooksV2Controller :ControllerBase
	{
        private readonly IServiceManager _manager;

        public BooksV2Controller(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookAsync()
        {
            var books = await _manager.BookServices.GetAllBooksAsync(false);
            var books2 = books.Select(s => new
            {
                Title = s.Title,
                Price = s.Price
            });
            return Ok(books);
        }
    }
}

