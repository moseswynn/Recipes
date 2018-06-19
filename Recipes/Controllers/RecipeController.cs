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
        
        // Get list of recipes and display when the home page is opened.
        public ActionResult Index()
        {
            var Recipes = db.Recipes.ToList();
            return View(Recipes);
        }

        //Get details of recipe or return 404
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if(recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }
    }
}