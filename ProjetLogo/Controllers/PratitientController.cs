using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetLogo.Models;

namespace ProjetLogo.Controllers
{
    public class PratitientController : Controller
    {
        public ApplicationDbContext _Context;

        public PratitientController()
        {
            _Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }

        // GET: Pratitient
        public ActionResult Index()
        {
            var pratitient = _Context.Personnes.ToList();

            return View(pratitient);
        }
    }
}