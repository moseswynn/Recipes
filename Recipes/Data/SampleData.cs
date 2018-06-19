using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Recipes.Models;
namespace Recipes.Data
{
    public class SampleData
    {
        public List<Recipe> Repo
        {
            get
            {
                return new List<Recipe>
                {
                    new Recipe()
                    {
                        RecipeId = 0,
                        Name = "Easy mac",
                        Description = "A microwavable bowl of mac and cheese."
                    },
                    new Recipe()
                    {
                        RecipeId = 1,
                        Name = "Chicken Tikka Masala",
                        Description = "An Indian-style curry dish that originated in London."
                    },
                    new Recipe()
                    {
                        RecipeId = 2,
                        Name = "Pizza",
                        Description = "Come on man, you know what it is... "
                    }
                };
            }
        }
    }
}