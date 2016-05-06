using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio.Entities;

namespace Biblioteca.Dominio.Interfaces
{
    public interface ICategoryRepository
    {
        void Inserir(Category category);
        Category RecuperarPorId(int id);
        List<Category> RecuperarTodos();
        Category Alterar(int id, Category novo);
        void Deletar(Category category);
        void Deletar(int id);
    }
}
