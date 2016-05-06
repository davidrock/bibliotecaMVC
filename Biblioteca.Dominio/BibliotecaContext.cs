using System.Data.Entity;
using Biblioteca.Dominio.Entities;
using Biblioteca.Dominio.Entities.Mapping;

namespace Biblioteca.Dominio
{
    public partial class BibliotecaContext : DbContext
    {
        static BibliotecaContext()
        {
            Database.SetInitializer<BibliotecaContext>(new CreateDatabaseIfNotExists<BibliotecaContext>());
        }

        public BibliotecaContext()
            : base("Name=BibliotecaContext")
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
