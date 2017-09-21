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
        
        public string cantidadTarifas(int cantidad)
        {
            string htmltarifas = "";
            for(int i = 0; i <= cantidad; i++)
            {
                string tarifa = "<div class=\"form - group\"> < h1 > Tarifa " + (i + 1) + "</ h1 ></ div >< div class=\"form-group\"><label>Nombre tarifa " + (i + 1) + "</label></div><div class=\"form-group\"><input type = \"text\" class=\"form-control\" required></div><div class=\"form-group\"><label>Descripcion tarifa " + (i + 1) + "</label></div><div class=\"form-group\"><textarea class=\"form-control\" required></textarea></div><div class=\"form-group\"><label>Precio de la tarifa" + (i + 1) + "</label></div><div class=\"form-group\"><input type = \"number\" class=\"form-control\" min=\"1\" max =\"10\" required ></div>";
                htmltarifas += tarifa;
            }

            return htmltarifas;
        }

        //[HttpPost]
        //public ActionResult login(FormCollection form)
        //{
        //    if(ModelState)
        //}
    }
}
