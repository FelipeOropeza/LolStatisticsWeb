using LolStatistics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LolStatistics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
         public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            var usuario = new Usuario(); //Criando o objeto para a classe
            return View(usuario); //Retorna para a view os dados da classe
        }
        [HttpPost]

        public ActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid) //Validando o estado, ou seja, verificando a requisição
            {
                return View("Resultado", usuario); //Retorna para a view Resultado
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario) //Criando a ação para a view resultado
        {
            return View(usuario);
        }
    }
}