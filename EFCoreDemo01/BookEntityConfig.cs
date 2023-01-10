using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDemo01
{
    public class BookEntityConfig:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("T_Books");
            builder.Property(r => r.Title).HasMaxLength(50).IsRequired();
            builder.Property(r => r.AuthorName).HasMaxLength(20).IsRequired();
        }
    }
}