using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio.Entities;
using Biblioteca.Dominio.Interfaces;

namespace Biblioteca.Dominio.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Inserir(Author author)
        {
            using (var ctx = new BibliotecaContext())
            {
                ctx.Authors.Add(author);
                ctx.SaveChanges();
            }
        }

        public Author RecuperarPorId(int id)
        {
            using (var ctx = new BibliotecaContext())
            {
                var cat = ctx.Authors.FirstOrDefault(x => x.Id == id);
                return cat;
            }
        }

        public List<Author> RecuperarTodos()
        {
            using (var ctx = new BibliotecaContext())
            {
                return ctx.Authors.ToList();
                
            }
        }

        public Author Alterar(int id, Author novo)
        {
            using (var ctx = new BibliotecaContext())
            {
                var aut = ctx.Authors.First(x => x.Id == id);
                aut.Name = novo.Name;

                ctx.Authors.Add(aut);
                ctx.SaveChanges();

                return aut;

            }
        }


        public void Deletar(Author author)
        {
            using (var ctx = new BibliotecaContext())
            {
                ctx.Authors.Remove(author);
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new BibliotecaContext())
            {
                var cat = ctx.Authors.First(x => x.Id == id);

                ctx.Authors.Remove(cat);
            }
        }
    }
}
