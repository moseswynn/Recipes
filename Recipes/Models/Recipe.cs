using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class Recipe
    {
        //PK for recipe table
        public int RecipeId { get; set; }
        //Title of the recipe
        public string Name { get; set; }
        //A short description of the recipe
        public string Description { get; set; }

        //Nav prop for one-to-many relationship of Recipe to Ingredients
        public List<Ingredient> Ingredients { get; set; }
        //Nav prop for one-to-many relationship of Recipe to Instructions
        public List<Instruction> Instructions { get; set; }
    }
}