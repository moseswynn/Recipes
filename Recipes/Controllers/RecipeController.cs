using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recipes.Models;
using Recipes.Data;
using System.Net;

namespace Recipes.Controllers
{
    public class RecipeController : Controller
    {
        private Context db = new Context();
        
        // GET: Recipe
        public ActionResult Index()
        {
            var Recipes = db.Recipes.ToList();
            return View(Recipes);
        }

    }
}