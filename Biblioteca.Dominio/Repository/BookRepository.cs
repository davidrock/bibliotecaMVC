using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio.Entities;
using Biblioteca.Dominio.Interfaces;

namespace Biblioteca.Dominio.Repository
{
    public class BookRepository : IBookRepository
    {
        public void Inserir(Book book)
        {
            using (var ctx = new BibliotecaContext())
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
            }
        }

        public Book RecuperarPorId(int id)
        {
            using (var ctx = new BibliotecaContext())
            {
                var book = ctx.Books.FirstOrDefault(x => x.Id == id);
                return book;
            }
        }

        public List<Book> RecuperarTodos()
        {
            using (var ctx = new BibliotecaContext())
            {
                return ctx.Books.ToList();

            }
        }

        public Book Alterar(int id, Book book)
        {
            using (var ctx = new BibliotecaContext())
            {
                var boo = ctx.Books.First(x => x.Id == id);
                boo.Name = book.Name;
                boo.Author = book.Author;
                boo.Category = book.Category;

                ctx.SaveChanges();

                return boo;

            }
        }

        public void Deletar(Book book)
        {
            using (var ctx = new BibliotecaContext())
            {
                ctx.Books.Remove(book);
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new BibliotecaContext())
            {
                var book = ctx.Books.First(x => x.Id == id);

                ctx.Books.Remove(book);
            }
        }
    }
}
