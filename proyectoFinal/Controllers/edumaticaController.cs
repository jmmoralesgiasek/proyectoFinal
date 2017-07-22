using Newtonsoft.Json;
using proyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
            ws.WebService1 webService = new ws.WebService1();
            var datos = webService.getEmpleados();
            var items = JsonConvert.DeserializeObject<List<Empleado>>(datos);
            return Json(items, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ExportPDFempleados()
        {
            return View();
        }

        public ActionResult pdf()
        {
            return new Rotativa.MVC.ActionAsPdf("ExportPDFempleados")
            {
                FileName = "Informacion.pdF"
            };

        }
    }
}