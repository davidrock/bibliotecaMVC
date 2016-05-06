using System.ComponentModel.DataAnnotations;

namespace TrabalhoBiblioteca.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Defina um nome para o livro")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Defina um autor para o livro")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Defina uma categoria para o livro")]
        public string Categoria { get; set; }
    }
}
