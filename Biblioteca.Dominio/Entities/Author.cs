using System.Collections.Generic;
namespace Biblioteca.Dominio.Entities
{
    public partial class Author
    {
        public Author()
        {
            this.Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
