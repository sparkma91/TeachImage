using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeachImageWebsite.Models;

namespace TeachImageWebsite.Controllers
{
    public class RecipeController : Controller
    {
        projectsqlEntities db = new projectsqlEntities();
        // GET: Recipe
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}