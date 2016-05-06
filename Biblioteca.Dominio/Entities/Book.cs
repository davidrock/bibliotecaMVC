
namespace Biblioteca.Dominio.Entities
{
    public partial class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}
