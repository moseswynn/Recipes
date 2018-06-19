using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class Instruction
    {
        //PK for instruction table
        public int InstructionId { get; set; }
        //Instruction index in recipe
        public int InstructionIndex { get; set; }
        //Instruction text
        public string InstructionText { get; set; }

        //Nav prop for many-to-one relationship from Instructions to Recipe
        public Recipe RelatedRecipe { get; set; }
    }
}