using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class Ingredient
    {
        //PK for Ingredients table
        public int IngredientId { get; set; }
        //Ingredient Text
        public string IngredientText { get; set; }

        //Nav prop from many-to-one relationship from Ingredient to Recipe
        public Recipe RelatedRecipe { get; set; }
    }
}