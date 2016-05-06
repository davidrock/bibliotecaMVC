using System.Collections.Generic;

namespace Biblioteca.Dominio.Entities
{
    public partial class Category
    {
        public Category()
        {
            this.Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
