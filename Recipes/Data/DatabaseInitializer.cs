using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Recipes.Models;
namespace Recipes.Data
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var easyMac = new Recipe()
            {
                Name = "Easy Mac",
                Description = "Mac that is easy"
            };

            var tunaSandwich = new Recipe()
            {
                Name = "Tuna Sandwich",
                Description = "A sandwich with Tuna Salad"
            };

            var glassOfWater = new Recipe()
            {
                Name = "Glass of Water",
                Description = "A glass with water in it."
            };

            var easyMacIngredients = new List<Ingredient>()
            {
                new Ingredient()
                {
                    IngredientText = "Cup of easy mac."
                },
                new Ingredient()
                {
                    IngredientText = "Water"
                }
            };
            easyMac.Ingredients = easyMacIngredients;

            var glassOfWaterIngredients = new List<Ingredient>()
            {
                new Ingredient()
                {
                    IngredientText = "A glass"
                },
                new Ingredient()
                {
                    IngredientText = "A faucet"
                }
            };
            glassOfWater.Ingredients = glassOfWaterIngredients;

            var tunaSandwichIngredients = new List<Ingredient>()
            {
                new Ingredient()
                {
                    IngredientText = "1 can tuna fish"
                },
                new Ingredient()
                {
                    IngredientText = "mayo"
                },
                new Ingredient()
                {
                    IngredientText = "mustard"
                },
                new Ingredient()
                {
                    IngredientText = "bread"
                }
            };
            tunaSandwich.Ingredients = tunaSandwichIngredients;

            var easyMacInstructions = new List<Instruction>
            {
                new Instruction()
                {
                    InstructionIndex = 0,
                    InstructionText = "Remove the lid from the cup and place aside cheese packet."
                },
                new Instruction()
                {
                    InstructionIndex = 1,
                    InstructionText = "Fille the cup with water to the fill line and stir."
                },
                new Instruction()
                {
                    InstructionIndex = 2,
                    InstructionText = "Microwave the cup for 3.5 mintues."
                },
                new Instruction()
                {
                    InstructionIndex = 3,
                    InstructionText = "Add cheese to cup and stir."
                },
                new Instruction()
                {
                    InstructionIndex = 4,
                    InstructionText = "Let cool, then enjoy!"
                }
            };
            easyMac.Instructions = easyMacInstructions;

            var glassOfWaterInstructions = new List<Instruction>
            {
                new Instruction()
                {
                    InstructionIndex = 0,
                    InstructionText = "Turn on faucet"
                },
                new Instruction()
                {
                    InstructionIndex = 1,
                    InstructionText = "Fill glass"
                },
                new Instruction()
                {
                    InstructionIndex = 2,
                    InstructionText = "To conserver water, turn off faucet."
                }
            };
            glassOfWater.Instructions = glassOfWaterInstructions;

            var tunaSandwichInstructions = new List<Instruction>
            {
                new Instruction()
                {
                    InstructionIndex = 0,
                    InstructionText = "Excluding bread, mix tuna fish and other ingredients (amount at your discretion) to desired incorporation."
                },
                new Instruction()
                {
                    InstructionIndex = 1,
                    InstructionText = "Spread the resulting spackle onto a slice of bread"
                },
                new Instruction()
                {
                    InstructionIndex = 2,
                    InstructionText = "Top with other slice of bread and eat."
                }
            };
            tunaSandwich.Instructions = tunaSandwichInstructions;

            context.Recipes.Add(glassOfWater);
            context.Recipes.Add(tunaSandwich);
            context.Recipes.Add(easyMac);

            context.SaveChanges();
        }
    }
}