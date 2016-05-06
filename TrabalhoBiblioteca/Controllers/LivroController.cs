using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabalhoBiblioteca.Controllers
{
    public class LivroController : Controller
    {
        // GET: Livro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }

        public ActionResult Excluir()
        {
            return View();
        }


    }
}