using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio.Entities;
using Biblioteca.Dominio.Interfaces;

namespace Biblioteca.Dominio.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Inserir(Category category)
        {
            using (var ctx = new BibliotecaContext())
            {
                ctx.Categories.Add(category);
                ctx.SaveChanges();
            }
        }

        public Category RecuperarPorId(int id)
        {
            using (var ctx = new BibliotecaContext())
            {
                var cat = ctx.Categories.FirstOrDefault(x => x.Id == id);
                return cat;
            }
        }

        public List<Category> RecuperarTodos()
        {
            using (var ctx = new BibliotecaContext())
            {
                return ctx.Categories.ToList();
                
            }
        }

        public Category Alterar(int id, Category novo)
        {
            using (var ctx = new BibliotecaContext())
            {
                var category = ctx.Categories.First(x => x.Id == id);
                category.Description = novo.Description;
                category.Books = novo.Books;

                ctx.SaveChanges();

                return category;
            }
        }

        public void Deletar(Category category)
        {
            using (var ctx = new BibliotecaContext())
            {
                ctx.Categories.Remove(category);
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new BibliotecaContext())
            {
                var cat = ctx.Categories.First(x => x.Id == id);

                ctx.Categories.Remove(cat);
            }
        }
    }
}
