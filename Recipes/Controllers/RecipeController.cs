using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recipes.Models;
using Recipes.Data;
namespace Recipes.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult Index()
        {
            SampleData data = new SampleData();
            var Recipes = data.Repo;
            return View(Recipes);
        }
    }
}