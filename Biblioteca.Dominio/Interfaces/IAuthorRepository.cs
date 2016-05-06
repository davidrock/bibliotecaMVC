using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio.Entities;

namespace Biblioteca.Dominio.Interfaces
{
    public interface IAuthorRepository
    {
        void Inserir(Author author);
        Author RecuperarPorId(int id);
        List<Author> RecuperarTodos();
        Author Alterar(int id, Author author);
        void Deletar(int id);
        void Deletar(Author author);
    }
}
