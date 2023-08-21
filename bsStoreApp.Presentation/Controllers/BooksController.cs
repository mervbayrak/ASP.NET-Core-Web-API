﻿using bsStoreApp.Entities.DataTransferObjects;
using bsStoreApp.Entities.Models;
using bsStoreApp.Services.Contract;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace bsStoreApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly  IServiceManager _manager;

        public BooksController(IServiceManager manager)
        {
            _manager = manager;
        }


        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _manager.BookServices.GetAllBooks(false);
            return Ok(books);
        }


        [HttpGet("{id:int}")]
        public IActionResult GetOneBook([FromRoute(Name = "id")] int id)
        {
            var book = _manager.BookServices.GetOneBookById(id, false);

            return Ok(book);
        }

        [HttpPost]
        public IActionResult CreateOneBook([FromBody] BookDtoForInsertion bookDto)
        {
            if (bookDto is null)
                return BadRequest(); //400

            var book = _manager.BookServices.CreateOneBook(bookDto);

            return StatusCode(201, book);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] BookDtoForUpdate book)
        {
            if (book is null)
                return BadRequest(); //400

            _manager.BookServices.UpdateOneBook(id, book, true);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBook([FromRoute(Name = "id")] int id)
        {
            _manager.BookServices.DeleteOneBook(id, true);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] JsonPatchDocument<BookDto> bookPatch)
        {
            var bookDto = _manager.BookServices.GetOneBookById(id, true);

            bookPatch.ApplyTo(bookDto);

            _manager.BookServices.UpdateOneBook(id,
                new BookDtoForUpdate()
                {
                    Id = bookDto.Id,
                    Price = bookDto.Price,
                    Title = bookDto.Title
                },
                true);

            return NoContent();
        }
    }
}
