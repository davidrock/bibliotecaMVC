using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Dominio.Entities.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            this.Property(t => t.ImageUrl)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Books");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AuthorId).HasColumnName("AuthorId");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");

            // Relationships
            this.HasRequired(t => t.Author)
                .WithMany(t => t.Books)
                .HasForeignKey(d => d.AuthorId);
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Books)
                .HasForeignKey(d => d.CategoryId);

        }
    }
}
