using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Progra1.Controllers
{
    public class VendedorController : Controller
    {
        public ActionResult InicioSesion()
        {
            return PartialView();
        }

        public ActionResult Servicios()
        {
            return View();
        }

        public ActionResult Registrarse()
        {
            return PartialView();
        }

        public ActionResult AgregarServicio()
        {
            return View();
        }
    }
}
