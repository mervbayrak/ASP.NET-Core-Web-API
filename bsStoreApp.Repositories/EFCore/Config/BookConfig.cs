using bsStoreApp.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace bsStoreApp.Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Karagöz", Price = 75 },
                new Book { Id = 2, Title = "Sefiller", Price = 50 },
                new Book { Id = 3, Title = "Küçük Prens", Price = 25 }
                );
        }
    }
}
