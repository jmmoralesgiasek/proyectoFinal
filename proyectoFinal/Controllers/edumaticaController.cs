using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoFinal.Controllers
{
    public class edumaticaController : Controller
    {
        // GET: edumatica
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getInformation()
        {
            /* ws.WebService1 webService = new ws.WebService1();
             return Json(webService.getEmpleados(), JsonRequestBehavior.AllowGet);*/

            var empleados = new List<object>();
            empleados.Add(new { nombre = "Cinthya", apellido = "Trejo", edad = "24", domicilio = "1984", ciudad="Quérétaro", estado = "Querétaro", id_departamento = 3});
            empleados.Add(new { nombre = "Juan", apellido = "López",edad = "23", domicilio = "1939", ciudad = "Quérétaro", estado = "Querétaro", id_departamento = 1 });
            return Json(empleados, JsonRequestBehavior.AllowGet);
        }
    }
}