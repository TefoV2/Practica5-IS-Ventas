using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// NOMBRE APELLIDOS: Estefano Galarza
// PARALELO: P3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 29/04/2024
// PRÁCTICA No. #5

namespace ApiREST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
