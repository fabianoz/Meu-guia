using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Empresa.com.Models;

namespace Empresa.com.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pesquisa pesquisa)
        {

            return View("_ResultadoPesquisa", pesquisa);
        }
        public ActionResult _ResultadoPesquisa()
        {
            return View();
        }
        public ActionResult _DadosEmpresa(Empresa_ empresa)
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            if (usuario.User.Equals("fabiano") && usuario.Senha.Equals("1993"))
            {
                return View("~/Areas/Painel/Views/HomePainel/_Painel.cshtml");
            }
            return View();
        }
        public ActionResult Gazin()
        {
            return View();
        }
        public ActionResult Novalar()
        {
            return View();
        }
        public ActionResult Romera()
        {
            return View();
        }
        public ActionResult citylar()
        {
            return View();
        }

    }
}