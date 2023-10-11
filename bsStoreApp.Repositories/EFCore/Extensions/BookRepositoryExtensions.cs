using bsStoreApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace bsStoreApp.Repositories.EFCore.Extensions
{
    public static class BookRepositoryExtensions
    {
        public static IQueryable<Book> FilterBooks(this IQueryable<Book> books, uint minPrice, uint maxPrice) =>
            books.Where(book => book.Price >= minPrice && book.Price <= maxPrice);

        public static IQueryable<Book> Search(this IQueryable<Book> books, string seachTerm)
        {
            if (string.IsNullOrWhiteSpace(seachTerm))
                return books;

            var lowerCaseTerm = seachTerm.Trim().ToLower();

            return books.Where(b => b.Title.ToLower().Contains(lowerCaseTerm));
        }

    }
}
