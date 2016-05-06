using System.Drawing.Design;
using AutoMapper;
using Biblioteca.Dominio.Entities;
using TrabalhoBiblioteca.Models;

namespace TrabalhoBiblioteca.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CategoryViewModel, Category>();
            Mapper.CreateMap<BookViewModel, Book>();
            Mapper.CreateMap<AuthorViewModel, Author>();
        }
    }
}