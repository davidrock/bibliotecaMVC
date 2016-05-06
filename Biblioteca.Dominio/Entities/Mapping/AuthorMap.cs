using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Dominio.Entities.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            this.Property(t => t.Country)
                .IsRequired();

            this.Property(t => t.ImageUrl)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Authors");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
        }
    }
}
