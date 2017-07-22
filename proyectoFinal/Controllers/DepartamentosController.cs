using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoFinal.Controllers
{
    public class DepartamentosController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getInformation()
        {
            /* ws.WebService1 webService = new ws.WebService1();
             return Json(webService.getEmpleados(), JsonRequestBehavior.AllowGet);*/

            var departamentos = new List<object>();
            departamentos.Add(new { nombreDep = "Sistemas", ciudad = "Querétaro" });
            departamentos.Add(new { nombreDep = "Ventas", ciudad = "Monterrey" });
            return Json(departamentos, JsonRequestBehavior.AllowGet);
        }
    }
}