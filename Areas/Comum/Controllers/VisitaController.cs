﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SICE.Controllers;
using SICE.Models;

namespace SICE.Areas.Comum.Controllers
{
    public class VisitaController : BaseController
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
                //var listaVisita = idbsiceContext.
                return View();
            }
            catch(Exception ex)
            {
                return Index();
            }
        }
    }
}