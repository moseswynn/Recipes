using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recipes.Models;
using Recipes.Data;
using System.Net;
using System.Data.Entity;

namespace Recipes.Controllers
{
    public class RecipeController : Controller
    {
        private Context context = new Context();
        
        // Get list of recipes and display when the home page is opened.
        public ActionResult Index()
        {
            var Recipes = context.Recipes.ToList(); //convert the recipes to a list
            return View(Recipes); //pass the list of recipes to the view
        }

        //Get details of the recipe based on it's id
        public ActionResult Detail(int? id)
        {
            //if an id was not specified return 400 
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //find the recipe, including it's ingredients and instructions, based on the specified id.
            var recipe = context.Recipes
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions)
                .ToList()
                .Find(r => r.RecipeId == id);

            if(recipe == null)
            {
                return HttpNotFound(); //return 404 if a recipe with the specified id can't be found
            }

            return View(recipe); //pass the recipe to the view
        }
    }
}