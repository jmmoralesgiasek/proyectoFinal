using Newtonsoft.Json;
using proyectoFinal.Models;
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
            ws.WebService1 webService = new ws.WebService1();
            var datos = webService.getDepartamentos();
            var items = JsonConvert.DeserializeObject<List<Departamento>>(datos);
            return Json(items, JsonRequestBehavior.AllowGet);
        }
    }
}