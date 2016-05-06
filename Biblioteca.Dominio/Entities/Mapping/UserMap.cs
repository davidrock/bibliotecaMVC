using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Dominio.Entities.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            this.Property(t => t.Login)
                .IsRequired();

            this.Property(t => t.Pass)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Pass).HasColumnName("Pass");
        }
    }
}
