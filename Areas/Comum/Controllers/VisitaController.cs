using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SICE.Areas.Comum.Controllers
{
    public class VisitaController : Controller
    {
        // GET: Comum/Visita
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home", new { Area = ""});
        }

        public ActionResult GerenciarVisitas()
        {
            try
            {
                return View();
            }
            catch(Exception ex)
            {
                return Index();
            }
        }
    }
}