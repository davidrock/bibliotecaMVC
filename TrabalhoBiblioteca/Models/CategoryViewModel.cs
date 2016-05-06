using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Dominio.Entities;

namespace TrabalhoBiblioteca.Models
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string Name { get; set; }
        public virtual ICollection<Book> Books{ get; set; }
    }
}
