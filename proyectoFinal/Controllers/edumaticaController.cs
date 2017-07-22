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
            
            return Json(, JsonRequestBehavior.AllowGet);
        }
    }
}