using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Biblioteca.Dominio;
using Biblioteca.Dominio.Entities;
using Biblioteca.Dominio.Interfaces;
using Biblioteca.Dominio.Repository;
using TrabalhoBiblioteca.Models;

namespace TrabalhoBiblioteca.Controllers
{
    public class BibliotecaController : Controller
    {
        private readonly IBookRepository _bookRep;

        public BibliotecaController(IBookRepository bookRep)
        {
            _bookRep = bookRep;
        }

        public ActionResult Index()
        {
            var ctx = new BibliotecaContext();

            var s = ctx.Books.ToList();

            var books = _bookRep.RecuperarTodos();

            var vm = Mapper.Map<IList<Book>, IList<BookViewModel>>(books.ToList());

            return View(vm);
        }
    }
}