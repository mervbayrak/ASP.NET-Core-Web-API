﻿using bsStoreApp.Entities.Models;
using bsStoreApp.Repositories.Contracts;

namespace bsStoreApp.Repositories.EFCore
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneBook(Book book) => Create(book);

        public void DeleteOneBook(Book book) => Delete(book);

        public void UpdateOneBook(Book book) => Update(book);

        public IQueryable<Book> GetAllBooks(bool trackChanges) => FindAll(trackChanges).OrderBy(b=>b.Id);

        public Book GetOneBookById(int id, bool trackChanges) => FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefault();

        
    }
}
