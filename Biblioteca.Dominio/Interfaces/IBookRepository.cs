using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio.Entities;

namespace Biblioteca.Dominio.Interfaces
{
    public interface IBookRepository
    {
        void Inserir(Book book);
        Book RecuperarPorId(int id);
        List<Book> RecuperarTodos();
        Book Alterar(int id, Book book);
        void Deletar(Book book);
        void Deletar(int id);
    }
}
