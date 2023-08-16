using bsStoreApp.Entities.Models;
using bsStoreApp.Repositories.EFCore.Config;
using Microsoft.EntityFrameworkCore;
namespace bsStoreApp.Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());

        }
    }
}
