using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Dominio.Entities.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Categories");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
