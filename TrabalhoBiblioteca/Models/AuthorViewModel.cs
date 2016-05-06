using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Dominio.Entities;

namespace TrabalhoBiblioteca.Models
{
    public class AuthorViewModel
    {
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Campo Nome é Obrigatório")]
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
