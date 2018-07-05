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
        
        // GET list of recipes and display when the home page is opened.
        public ActionResult Index()
        {
            var Recipes = context.Recipes.ToList(); //convert the recipes to a list
            return View(Recipes); //pass the list of recipes to the view
        }

        // GET details of the recipe based on it's id
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

        //GET the new recipe form
        public ActionResult New()
        {
            return View();
        }

        //POST a new recipe
        [HttpPost]
        public ActionResult New(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                context.Recipes.Add(recipe);
                context.SaveChanges();
                var response = "success";
                return Content(response);
            }
            else
            {
                var response = "failure";
                return Content(response);
            }
            
        }

        //GET the edit recipe form
        public ActionResult Edit(int? id)
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

            if (recipe == null)
            {
                return HttpNotFound(); //return 404 if a recipe with the specified id can't be found
            }

            return View(recipe); //pass the recipe to the view
        }

        //POST edit recipe form
        [HttpPost]
        public ActionResult Edit (Recipe recipe)
        {
            var toUpdate = context.Recipes.Find(recipe.RecipeId);
            context.Recipes.Remove(toUpdate);
            context.Recipes.Add(recipe);
            context.SaveChanges();

            return Content("success");
        }
        //GET delete recipe from database
        public ActionResult Delete(int? id)
        {
            context.Recipes.Remove(context.Recipes.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}