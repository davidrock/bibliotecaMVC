using AutoMapper;
using Biblioteca.Dominio.Entities;
using TrabalhoBiblioteca.Models;

namespace TrabalhoBiblioteca.Mappers
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Category, CategoryViewModel>();
            Mapper.CreateMap<Book, BookViewModel>();
            Mapper.CreateMap<Author, AuthorViewModel>();
        }
    }
}